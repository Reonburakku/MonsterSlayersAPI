using AutoMapper;
using MonsterSlayersAPI.BLL.Entities;
using MonsterSlayersAPI.BLL.Interfaces;
using MonsterSlayersAPI.BLL.Interfaces.Repositories;
using MonsterSlayersAPI.BLL.Models.Request.Base;
using MonsterSlayersAPI.BLL.Models.Request.Game;
using MonsterSlayersAPI.BLL.Models.Result;
using MonsterSlayersAPI.BLL.Services;
using Moq;

namespace MonsterStalersAPI.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            Mock<IBattleRepository> batleRepoMock = new Mock<IBattleRepository>();
            batleRepoMock.Setup(a => a.GetByIdAsync(1, 1)).Returns(new ValueTask<Battle>(new Battle
            {
                BattleId = 1,
                ZoneId = 1,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                TeamWinner = "",
                Turn = 1,
                Round = 1,
                Zone = new Zone
                {
                    ZoneId = 1,
                    Image = ""
                }
            }));
            Mock<IUnitOfWork> unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(a => a.BattleRepository).Returns(batleRepoMock.Object);

            Mock<IMapper> mapperMock = new Mock<IMapper>();
            mapperMock.Setup(m => m.Map<Battle, BattleResultModel>(It.IsAny<Battle>())).Returns(new BattleResultModel
            {
                BattleId = 1,
                TeamWinner = "",
                Turn = 1,
                Round = 1,
                BattleActions = new List<MonsterSlayersAPI.BLL.Models.Battle.BattleActionModel>(),
                Message = "",
                Participants = new List<ParticipantResultModel>(),
                ZoneResultModel = new ZoneResultModel()
            });
            mapperMock.Setup(m => m.Map<BattleResultModel, Battle>(It.IsAny<BattleResultModel>())).Returns(new Battle
            {
                BattleId = 1,
                TeamWinner = "",
                Turn = 1,
                Round = 1
            });

            BattleService service = new BattleService(unitOfWorkMock.Object, mapperMock.Object, batleRepoMock.Object);

            var result = service.GetBattleByIdAsync(new GetBattleByIdModel
            {
                Id = 1,
                LanguageId = 1,
                Origin = "test"
            });

            Assert.That(result, Is.Not.Null);
        }
    }
}