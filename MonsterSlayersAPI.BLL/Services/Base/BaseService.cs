using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MonsterSlayersAPI.BLL.Interfaces;
using MonsterSlayersAPI.BLL.Interfaces.Repositories;
using MonsterSlayersAPI.BLL.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Services.Base
{
    public class BaseService : IBaseService
    {
        internal IBattleRepository _battleRepository;
        internal IUnityOfWork _unityOfWork;
        internal IMapper _mapper;

        public BaseService(IUnityOfWork unityOfWork, IBattleRepository battleRepository, IMapper mapper)
        {
            _battleRepository = battleRepository;
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }
    }
}
