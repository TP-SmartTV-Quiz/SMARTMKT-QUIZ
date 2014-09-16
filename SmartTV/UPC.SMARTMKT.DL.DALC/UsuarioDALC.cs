using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UPC.SMARTMKT.DL.DATAMODEL;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace UPC.SMARTMKT.DL.DALC
{
    public class UsuarioDALC
    {
        public USUARIO UsuarioObtener(String sUsuario)
        {
            String sCadena;
            String sqlObtenerUsuario;
            SqlCommand cmdObtnerUsuario;
            SqlConnection Conn;

            SqlParameter PrmUsuario;
            USUARIO objUusario;
            SqlDataReader drObtenerUsuario;
            try
            {/*
                SMARTMKTDataContext objModel = new SMARTMKTDataContext(ConfigurationManager.ConnectionStrings["SMARTMKT"].ToString());
                USUARIO objUsuario = (from objUser in objModel.USUARIOs
                                      where objUser.USUARIO1.Equals(sUsuario)
                                      select objUser).FirstOrDefault();
                return objUsuario;
              */
                sCadena = "server=(local);database=SMARTMKT;User Id=sa;Password=password";
                sqlObtenerUsuario = "UspObtenerUsuario";

                Conn = new SqlConnection(sCadena);
                cmdObtnerUsuario = new SqlCommand(sqlObtenerUsuario, Conn);
                cmdObtnerUsuario.CommandType = CommandType.StoredProcedure;

                PrmUsuario = new SqlParameter();
                PrmUsuario.ParameterName = "@USUARIO1";
                PrmUsuario.SqlDbType = SqlDbType.VarChar;
                PrmUsuario.Value = sUsuario;

                cmdObtnerUsuario.Parameters.Add(PrmUsuario);
                cmdObtnerUsuario.Connection.Open();
                drObtenerUsuario = cmdObtnerUsuario.ExecuteReader();
                objUusario = new USUARIO();

                if (drObtenerUsuario.Read())
                {
                    objUusario.USUARIO1 = drObtenerUsuario.GetString(drObtenerUsuario.GetOrdinal("USUARIO"));
                    objUusario.NOMBRE = drObtenerUsuario.GetString(drObtenerUsuario.GetOrdinal("NOMBRE"));
                    objUusario.CONTRASEÑA = drObtenerUsuario.GetString(drObtenerUsuario.GetOrdinal("CONTRASEÑA"));
                    objUusario.FECNACIMIENTO = drObtenerUsuario.GetDateTime(drObtenerUsuario.GetOrdinal("FECNACIMIENTO"));
                    objUusario.CORREO = drObtenerUsuario.GetString(drObtenerUsuario.GetOrdinal("CORREO"));
                }
                cmdObtnerUsuario.Connection.Close();
                return objUusario;
                
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public bool CrearUsuario(USUARIO objUsuario)
        {

            String sCadena;
            String sqlRegistrarUsuario;
            SqlCommand cmdRegistrarUsuario;
            SqlConnection Conn;

            USUARIO objUsario2;

            SqlParameter prmUSUARIO;
            SqlParameter prmCONTRASEÑA;
            SqlParameter prmCORREO;
            SqlParameter prmFECNACIMIENTO;
            SqlParameter prmNOMBRE;
            try
            {/*
                SMARTMKTDataContext objModel = new SMARTMKTDataContext(ConfigurationManager.ConnectionStrings["SMARTMKT"].ToString());

                USUARIO objUsuario2 = (from objUser in objModel.USUARIOs
                                       where objUser.USUARIO1.Equals(objUsuario.USUARIO1)
                                       select objUsuario).SingleOrDefault();
                if (objUsuario2 != null)
                {
                    return false;
                }
                else
                {

                    objModel.USUARIOs.InsertOnSubmit(objUsuario);
                    objModel.SubmitChanges();
                    return true;
                }
                */

                objUsario2 = UsuarioObtener(objUsuario.USUARIO1);
                if (objUsario2.USUARIO1 == objUsuario.USUARIO1)
                {
                    return false;
                }
                else
                {

                    sCadena = "server=(local);database=SMARTMKT;User Id=sa;Password=password";
                    sqlRegistrarUsuario = "UspRegistrarUsuario";

                    Conn = new SqlConnection(sCadena);
                    cmdRegistrarUsuario = new SqlCommand(sqlRegistrarUsuario, Conn);
                    cmdRegistrarUsuario.CommandType = CommandType.StoredProcedure;

                    prmUSUARIO = new SqlParameter();
                    prmUSUARIO.ParameterName = "@USUARIO";
                    prmUSUARIO.SqlDbType = SqlDbType.VarChar;
                    prmUSUARIO.Size = 20;
                    prmUSUARIO.Value = objUsuario.USUARIO1;

                    prmCONTRASEÑA = new SqlParameter();
                    prmCONTRASEÑA.ParameterName = "@CONTRASEÑA";
                    prmCONTRASEÑA.SqlDbType = SqlDbType.VarChar;
                    prmCONTRASEÑA.Size = 50;
                    prmCONTRASEÑA.Value = objUsuario.CONTRASEÑA;

                    prmCORREO = new SqlParameter();
                    prmCORREO.ParameterName = "@NOMBRE";
                    prmCORREO.SqlDbType = SqlDbType.VarChar;
                    prmCORREO.Size = 150;
                    prmCORREO.Value = objUsuario.NOMBRE;

                    prmFECNACIMIENTO = new SqlParameter();
                    prmFECNACIMIENTO.ParameterName = "@FECNACIMIENTO";
                    prmFECNACIMIENTO.SqlDbType = SqlDbType.Date;
                    prmFECNACIMIENTO.Value = objUsuario.FECNACIMIENTO.Date;

                    prmNOMBRE = new SqlParameter();
                    prmNOMBRE.ParameterName = "@CORREO";
                    prmNOMBRE.SqlDbType = SqlDbType.VarChar;
                    prmNOMBRE.Size = 150;
                    prmNOMBRE.Value = objUsuario.CORREO;

                    cmdRegistrarUsuario.Parameters.Add(prmUSUARIO);
                    cmdRegistrarUsuario.Parameters.Add(prmCONTRASEÑA);
                    cmdRegistrarUsuario.Parameters.Add(prmNOMBRE);
                    cmdRegistrarUsuario.Parameters.Add(prmFECNACIMIENTO);
                    cmdRegistrarUsuario.Parameters.Add(prmCORREO);

                    cmdRegistrarUsuario.Connection.Open();
                    cmdRegistrarUsuario.ExecuteNonQuery();
                    cmdRegistrarUsuario.Connection.Close();

                    return true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
