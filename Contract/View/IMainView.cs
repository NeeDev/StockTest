using System.Windows.Forms;

namespace Stock.Contract.View
{
    interface IMainView 
    {
        TextBox tbSearchStock { get;}
        AxKHOpenAPILib.AxKHOpenAPI KH_OpenAPI { get; }
    }
}
