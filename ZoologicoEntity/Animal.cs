namespace ZoologicoEntity
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class Animal
    {
        [DataMember]
        public int anim_id { get; set; }

        [DataMember]
        public string anim_nombre { get; set; }

        [DataMember]
        public int anim_edad { get; set; }

        [DataMember]
        public string anim_origen { get; set; }

        [DataMember]
        public string anim_tipo_alimento { get; set; }

        [DataMember]
        public int anim_cantidad { get; set; }

        [DataMember]
        public int gene_id { get; set; }

        [DataMember]
        public string gene_nombre { get; set; }

        [DataMember]
        public int espe_id { get; set; }        

        [DataMember]
        public string espe_nombre { get; set; }

        [DataMember]
        public int esta_id { get; set; }

        [DataMember]
        public string esta_titulo { get; set; }
    }
}
