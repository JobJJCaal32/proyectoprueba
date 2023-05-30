using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos.BaseDatos
{
    public class ClsDataBase
    {
        // se divide la clase en 5 regiones para tener mas controlado el codigo y ordenado

        #region VariablesPrivadas
        //Sirve para poder crear la conexion a base de datos con usuario, contraseña, instancia permite ejecutar la conexion
        private SqlConnection _objSqlConnection; 

        //son dos formas de enviar consulta a base de datos
        // el DataAdapter hace la lectura de los datos en la base de datos, se usa con un select
        private SqlDataAdapter _objSqlDataAdapter;

        //Permite usar los comandos para poder crear, actualizar(modificar), y eliminar
        private SqlCommand _objSqlCommand;

        //sirve para poder almacenar una lista de tablas y permite enviar las tablas para ser procesadas
        private DataSet _datasetResultados;

        //contruye los parametros que se le pasan a (SqlDataAdapter y Sql Command) se utilizan procesos almacenados hacia la base de datos 
        private DataTable _datatableParametros;
        // (SP proceso Alamacenado) 
        private string _NombreTabla, _NombreSp, _MensajeErrorDB, _ValorScalar, _NombreDB;
        private bool _Scalar;
        #endregion


        #region VariablesPublicas
        // se declaran variables publicas referenciando a las variables privadoas quitando el guion bajo e iniciando en mayuscula
        // se hace un get y set con el nombre de las variables privadas 
        public SqlConnection ObjSqlConnection { get => _objSqlConnection; set => _objSqlConnection = value; }
        public SqlDataAdapter ObjSqlDataAdapter { get => _objSqlDataAdapter; set => _objSqlDataAdapter = value; }
        public SqlCommand ObjSqlCommand { get => _objSqlCommand; set => _objSqlCommand = value; }
        public DataSet DataSetResultados { get => _datasetResultados; set => _datasetResultados = value; }
        public DataTable DataTableParametros { get => _datatableParametros; set => _datatableParametros = value; }
        public string NombreTabla { get => _NombreTabla; set => _NombreTabla = value; }
        public string NombreSp { get => _NombreSp; set => _NombreSp = value; }
        public string MensajeErrorDB { get => _MensajeErrorDB; set => _MensajeErrorDB = value; }
        public string ValorScalar { get => _ValorScalar; set => _ValorScalar = value; }
        public string NombreDB { get => _NombreDB; set => _NombreDB = value; }
        public bool Scalar { get => _Scalar; set => _Scalar = value; }
        #endregion

        #region Constructores
        // se hace un constructor para poder inicializar la tabla de parametros de la variables publicas 
        //para que estas no agarren un valor por default 
        public ClsDataBase() {
            DataTableParametros = new DataTable("SpParametros");
            DataTableParametros.Columns.Add("Nombre");
            DataTableParametros.Columns.Add("TipoDato");
            DataTableParametros.Columns.Add("Valor");

            NombreDB = string.Empty; 

        }
        #endregion

        #region MetodosPrivados
        /* se contryen metodos para poder trabajar con la conexion a la base de datos
        los metodos private void no retornan nada porque trabajan con datos por referencia, para que los objetos no cambien su 
        posicion en memoria y asi los cambios que se hagan le afecten al obejto que se este manipulando o trabajando esto se hace por
        medio de los private void*/

        //sirve para poder crear una base de datos, cuando tengo una sola base o si tengo varias bases de datos
        private void CrearConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {
            ObjDataBase.ObjSqlConnection = new SqlConnection();
        }
        //para poder validar si la conezion esta habierta o cerrada, y si esta habierta que la cierre y que la quite de memoria para 
        //ahorrar datos
        private void ValidarConxionBaseDatos(ref ClsDataBase ObjDataBase)
        {
            if (/*ObjDataBase.ObjConnection.State = ConnectionState.Closed*/)
            {

            }
        }
        private void AgregarParametros(ref ClsDataBase ObjDataBase)
        {

        }
        private void PreparaConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {

        }
        private void EjecutarDataAdapter(ref ClsDataBase ObjDataBase)
        {

        }
        private void EjecutarCommand(ref ClsDataBase ObjDataBase)
        {

        }

        #endregion

        #region MetodosPublicos

        #endregion
    }
}
