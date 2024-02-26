using AutoMapper;
using MediatR;
using nApplication.Features.Brands.Dtos;
using nApplication.Features.Brands.Rules;
using nApplication.Services.Repositories;
using nDomain.Entities;

namespace nApplication.Features.Brands.Commands.CreateBrand
{
    public class CreateBrandCommand : IRequest<CreatedBrandDto>
    {
        public string Name { get; set; }
        public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandDto>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;
            private readonly BrandBusinessRules _brandBusinessRules;

            public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
                _brandBusinessRules = brandBusinessRules;
            }

            public async Task<CreatedBrandDto> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
            {
                //iş kuralları
                await _brandBusinessRules.BrandNameCanNotBeDuplicatedWhenInserted(request.Name);

                //Gelen istek Brand entity'sine göre maplendi.
                Brand mappedBrand = _mapper.Map<Brand>(request);

                //Veri tabanına ekleme işlemi yapıldı.
                Brand createdBrand = await _brandRepository.AddAsync(mappedBrand);

                //Dönen veritabanı nesnesi Data Transfer Object(DTO)'e dönüştürülüp dönüldü.
                //Son kullanıcıya veritabanı nesnesi iletilmemesi için bu şekilde yapılmaktadır.
                CreatedBrandDto createdBrandDto = _mapper.Map<CreatedBrandDto>(createdBrand);

                return createdBrandDto;
            }
        }
    }
}

