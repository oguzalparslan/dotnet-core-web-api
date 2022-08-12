using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myApp.Core.Dtos;
using myApp.Core.Models;
using myApp.Core.Services;

namespace myApp.API.Controllers
{
    public class CustomerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Customer> _service;

        public CustomerController(IService<Customer> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _service.GetAllAsync();
            var customersDto = _mapper.Map<CustomerDto>(customers.ToList());
            return CreateActionResult(CustomResponseDto<List<CustomerDto>>.Success(204));
        }

    }
}
