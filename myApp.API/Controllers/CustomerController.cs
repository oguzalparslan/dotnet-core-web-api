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
        public async Task<IActionResult> GetAll()
        {
            var customers = await _service.GetAllAsync();
            var customersDto = _mapper.Map<List<CustomerDto>>(customers.ToList());

            return CreateActionResult(CustomResponseDto<List<CustomerDto>>.Success(200, customersDto));

            //return CreateActionResult(
            //    CustomResponseDto<List<CustomerDto>>.Success(
            //       200, _mapper.Map<List<CustomerDto>>(
            //            await _service.GetAllAsync()
            //            )
            //        )
            //    );
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
            var membershipDate = DateTime.Now;

            var customer = _mapper.Map<Customer>(customerdto);
            customer.MembershipDate = membershipDate;

            var added = await _service.AddAsync(customer);

            var customerDto = _mapper.Map<CustomerDto>(added);

            return CreateActionResult(CustomResponseDto<CustomerDto>.Success(204, customerDto));
        }


        [HttpPut]
        public async Task<IActionResult> Update(CustomerUpdateDto customer_dto)
        {
            //await Task.Run(() =>
            //{
            //    _service.UpdateAsync(_mapper.Map<Customer>(customer_dto));

            //});
            
            await _service.UpdateAsync(_mapper.Map<Customer>(customer_dto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        
    }
}
