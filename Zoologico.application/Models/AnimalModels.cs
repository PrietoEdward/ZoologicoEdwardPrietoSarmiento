using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoologico.application.Models
{
    public class AnimalModels
    {
        public int anim_id { get; set; }

        public string anim_nombre { get; set; }

        public int anim_edad { get; set; }

        public string anim_origen { get; set; }

        public string anim_tipo_alimento { get; set; }

        public int anim_cantidad { get; set; }

        public int gene_id { get; set; }

        public string gene_nombre { get; set; }

        public int espe_id { get; set; }

        public string espe_nombre { get; set; }

        public int esta_id { get; set; }

        public string esta_titulo { get; set; }
    }
}