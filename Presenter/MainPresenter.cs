using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Contract.View;
using Stock.Contract.Model;

namespace Stock.Presenter
{
    class MainPresenter
    {
        IMainView view;
        IMainModel model;

        public MainPresenter(IMainView view)
        {
            this.view = view;
        }
    }
}
