using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoologicoDAL.Connection;
using ZoologicoEntity;

namespace ZoologicoDAL
{
    
    public class AnimalDAL
    {
        private string CadenaConexion;
        public AnimalDAL()
        {
            CadenaConexion = ConnectionDAL.ObtenerCadenaConexiondb();
        }

        //select
        public List<Animal> ConsultarAnimal()
        {
            List<Animal> resultado = new List<Animal>();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                resultado = conexion.Query<Animal>("[dbo].[SP_GET_ANIMAL]", parameters, commandType: CommandType.StoredProcedure).ToList();

                conexion.Close();
            }

            return resultado;
        }

        //select ID
        public Animal ConsultarAnimalId(int anim_id)
        {
            Animal resultado = new Animal();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@anim_id", anim_id);
                resultado = conexion.Query<Animal>("[dbo].[SP_GET_ANIMAL_ID]", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();

                conexion.Close();
            }

            return resultado;
        }

        //insert
        public void IngresarAnimal(Animal Obejto)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@anim_nombre", Obejto.anim_nombre);
                parameters.Add("@anim_edad", Obejto.anim_edad);
                parameters.Add("@anim_origen", Obejto.anim_origen);
                parameters.Add("@anim_tipo_alimento", Obejto.anim_tipo_alimento);
                parameters.Add("@anim_cantidad", Obejto.anim_cantidad);
                parameters.Add("@espe_id", Obejto.espe_id);
                parameters.Add("@gene_id", Obejto.gene_id);
                parameters.Add("@esta_id", Obejto.esta_id);
                conexion.Execute("[dbo].[SP_INS_ANIMAL]", parameters, commandType: CommandType.StoredProcedure);
                conexion.Close();
            }
        }

        //update
        public void ActualizarAnimal(Animal Obejto)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@anim_id", Obejto.anim_id);
                parameters.Add("@anim_nombre", Obejto.anim_nombre);
                parameters.Add("@anim_edad", Obejto.anim_edad);
                parameters.Add("@anim_origen", Obejto.anim_origen);
                parameters.Add("@anim_tipo_alimento", Obejto.anim_tipo_alimento);
                parameters.Add("@anim_cantidad", Obejto.anim_cantidad);
                conexion.Execute("[dbo].[SP_UPD_ANIMAL]", parameters, commandType: CommandType.StoredProcedure);
                conexion.Close();
            }
        }

        //delete
        public void BorrarAnimal(int anim_id)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@anim_id", anim_id);
                conexion.Execute("[dbo].[SP_DEL_ANIMAL]", parameters, commandType: CommandType.StoredProcedure);
                conexion.Close();
            }
        }


    }
}
