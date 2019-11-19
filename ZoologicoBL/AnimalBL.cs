using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoologicoEntity;
using ZoologicoDAL;

namespace ZoologicoBL
{
    public class AnimalBL
    {
        //select
        public List<Animal> ConsultarAnimal()
        {
            List<Animal> resultado = new List<Animal>();
            AnimalDAL AnimDAL = new AnimalDAL();
            var lista = AnimDAL.ConsultarAnimal();
            resultado = lista;
            return resultado;
        }

        public Animal ConsultarAnimalId(int id)
        {
            Animal resultado = new Animal();
            AnimalDAL AnimDAL = new AnimalDAL();
            var lista = AnimDAL.ConsultarAnimalId(id);
            resultado = lista;
            return resultado;
        }

        //insert
        public void IngresarAnimal(Animal Obejto)
        {
            AnimalDAL AnimDAL = new AnimalDAL();
            AnimDAL.IngresarAnimal(Obejto);
        }

        //update
        public void ActualizarAnimal(Animal Obejto)
        {
            AnimalDAL AnimDAL = new AnimalDAL();
            AnimDAL.ActualizarAnimal(Obejto);
        }
        

        //delete
        public void BorrarAnimal(int id)
        {
            AnimalDAL AnimDAL = new AnimalDAL();
            AnimDAL.BorrarAnimal(id);
        }

    }
}
