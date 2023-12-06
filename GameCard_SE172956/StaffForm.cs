using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Service;
using Repositories.Models;
using Repositories.Models;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCard_SE172956
{
    public partial class StaffForm : Form
    {
        private GameCardInfoService gameCardService = new GameCardInfoService();
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            var result = gameCardService.GetAllGameCardInfo();

            var displayList = result.Select(gameCard => new
            {
                gameCard.GameCardId,
                gameCard.GameCardName,
                gameCard.GameDescription,
                gameCard.GamePlatform,
                gameCard.Price,
                gameCard.Quantity,
                gameCard.CreatedDate,
                gameCard.ProviderId,
                ProviderName = gameCard.Provider?.ProviderName,
            }).ToList();

            dgvGameCardList.DataSource = null;
            dgvGameCardList.DataSource = displayList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StaffForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
