using Repositories;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class GameCardInfoService
    {
        private GameCardInfoRepository _repo = new GameCardInfoRepository();

        public List<GameCardInfo> GetAllGameCardInfo()
        {
            return _repo.GetAll();
        }
        public List<GameCardInfo> SearchGameCardInfo(string keyword)
        {
            return _repo.GetAll().Where(s => s.GamePlatform.ToLower().Contains(keyword.ToLower()) ||
                                             s.GameDescription.ToLower().Contains(keyword.ToLower())).ToList();
        }
        public void DeleteGameCardInfo(int id)
        {
            _repo.Delete(id);
        }

        public GameCardInfo? GetAGameCardInfo(int id)
        {
            return _repo.Get(id);
        }

        public void UpdateAGameCardInfo(GameCardInfo gameCard)
        {
            _repo.Update(gameCard); 
        }

        public void AddAGameCardInfo(GameCardInfo gameCard)
        {
            _repo.Create(gameCard); 
        }
    }
}
