using System.Windows.Forms;

namespace Stock.Contract.View
{
    interface IMainView 
    {
        TextBox t_searchStock { get;}
        AxKHOpenAPILib.AxKHOpenAPI KH_OpenAPI { get; }
    }
}
