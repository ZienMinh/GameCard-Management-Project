using Repositories.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;

namespace Repositories
{
    public class GameCardInfoRepository
    {
        private GameCard2023DBContext context;

        public GameCardInfo? Get(int GameCardId)
        {
            context = new GameCard2023DBContext();

            return context.GameCardInfos.Find(GameCardId);
        }

        public List<GameCardInfo> GetAll()
        {
            context = new GameCard2023DBContext();

            return context.GameCardInfos.Include(card => card.Provider).ToList();
        }

        public void Create(GameCardInfo gameCard)
        {
            context = new GameCard2023DBContext();
            context.GameCardInfos.Add(gameCard);
            context.SaveChanges();
        }

        public void Update(GameCardInfo gameCard)
        {
            context = new GameCard2023DBContext();
            context.GameCardInfos.Update(gameCard);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context = new GameCard2023DBContext();
            var gameCard = context.GameCardInfos.FirstOrDefault(b => b.GameCardId == id);

            if (gameCard != null)
            {
                context.GameCardInfos.Remove(gameCard);
                context.SaveChanges();
            }
        }
    }
}
