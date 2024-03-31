using AutoMapper;
using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Interfaces;
using MonsterSlayersAPI.BLL.Interfaces.Repositories;
using MonsterSlayersAPI.BLL.Interfaces.Services;
using MonsterSlayersAPI.BLL.Models.Request.Game;
using MonsterSlayersAPI.BLL.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Services
{
    public class CharacterService : BaseService, ICharacterService
    {
        public CharacterService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<bool> SetCharacterZoneId(SetCharacterZoneIdModel model)
        {
            try
            {
                Character character = await _unitOfWork.CharacterRepository.GetByIdAsync(model.CharacterId);
                if (character == null)
                {
                    return false;
                }
                character.ZoneId = model.ZoneId;
                _unitOfWork.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
