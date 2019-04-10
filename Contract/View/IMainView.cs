using System.Windows.Forms;


namespace Stock.Contract.View
{
    interface IMainView 
    {
        TextBox tbSearchStock { get;}
        PictureBox btClose { get; }
        AxKHOpenAPILib.AxKHOpenAPI KH_OpenAPI { get; }

        void Close();
    }
}
