using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAPI.Domain.Entities;
using TesteAPI.Domain.Handlers;
using TesteAPI.Infra.Repository;

namespace TesteAPI.Web.Controllers
{
    [ApiController]
    [Route(template:"V1/niveis")]
    public class NivelController : ControllerBase
    {
        private readonly NivelCommandHandler _nivelCommandHandler;
        private readonly NivelRepository _nivelRepository;

        public NivelController(NivelCommandHandler nivelCommandHandler, NivelRepository nivelRepository)
        {
            _nivelCommandHandler = nivelCommandHandler;
            _nivelRepository = nivelRepository;
        }

        [HttpGet]
        public List<Nivel> Get()
        {
            return _nivelRepository.ObterTodos().ToList();
        }
    }
}
