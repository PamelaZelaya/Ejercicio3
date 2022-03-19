using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class BaseUsuario
    {
        readonly string Cadena = "Server=localhost; Port=3306; Database=Base_Ejercicio3; Uid=root; Pwd=123456789;";

        MySqlConnection conexion;
        MySqlCommand comando;


        public Usuario Login(string Usuario, string Clave)
        {
            Usuario User = null;

            try
            {
                string sql = "SELECT * FROM Usuario WHERE Clave = @Clave;";


                conexion = new MySqlConnection(Cadena);
                conexion.Open();

                comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@Clave", Clave);

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    User = new Usuario();
                    User.NombreUsuario = reader[0].ToString();
                    User.Clave = reader[1].ToString();
                }

                reader.Close();
                conexion.Close();

            }

            catch (Exception )
            {

            }

            return User;

        }


        public DataTable Listado()
        {
            DataTable listadoBase = new DataTable();
            try
            {
                string sql = "SELECT * FROM Uusario;";
                conexion = new MySqlConnection(Cadena);
                conexion.Open();

                comando = new MySqlCommand(sql, conexion);

                MySqlDataReader reader = comando.ExecuteReader();
                listadoBase.Load(reader);



            }
            catch (Exception ex)
            {

            }
            return listadoBase;
        }



    }
}
