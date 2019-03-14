using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Contract;
using Stock.Model;

namespace Stock.Presenter
{
    class AccountPresenter : IAccountPresenter
    {
        IAccountView view;
        IAccountModel model;

        public AccountPresenter(IAccountView view)
        {
            this.view = view;
            this.model = new AccountModel();
        }
        public void getAccountInfo()
        {
            string userID   = model.getData(AccountModel.USER_ID);
            string userName = model.getData(AccountModel.USER_NAME);
            string AccList  = model.getData(AccountModel.USER_ACCLIST);

            view.DisplayUserID(userID);
            view.DisplayUserName(userName);
            view.DisplayAccList(AccList);
        }
    }
}
