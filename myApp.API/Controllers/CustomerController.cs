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

        //api/Customer
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return CreateActionResult(
                CustomResponseDto<CustomerDto>.Success(
                    200, _mapper.Map<CustomerDto>(
                        await _service.GetAllAsync()
                        )
                    )
                );
        }
        //api/Customer/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var customer = await _service.GetByIdAsync(id);
            var customerDto = _mapper.Map<CustomerDto>(customer);
            return CreateActionResult(CustomResponseDto<CustomerDto>.Success(200, customerDto));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CustomerDto customerdto)
        {
            var added = await _service.AddAsync(_mapper.Map<Customer>(customerdto));
            var customerDto = _mapper.Map<CustomerDto>(added);
            return CreateActionResult(CustomResponseDto<CustomerDto>.Success(204, customerDto));
        }


        //[HttpPut]
        //public async Task<IActionResult> Update(CustomerUpdateDto customerDto)
        //{
        //    var customer = _mapper.Map<Customer>(customerDto);
        //    await _service.UpdateAsync(customer);
        //    return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        //}

    }
}
