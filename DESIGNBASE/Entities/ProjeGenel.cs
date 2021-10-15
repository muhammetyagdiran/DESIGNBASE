using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DESIGNBASE.Entities
{
    public class ProjeGenel
    {
        [Key]
        public int ID { get; set; }
        public string TASARIM_BELGESI_NO { get; set; }

        public string TRAFO_TANIM_KODU { get; set; }
        public string PN { get; set; }
        public string PROJE_ADI { get; set; }
        public string FREKANS { get; set; }
        public string SOGUTMA_SEKLI { get; set; }
        public string SOGUTMA_SEKLI1 { get; set; }
        public string SOGUTMA_SEKLI2 { get; set; }
        public string SOGUTMA_SEKLI3 { get; set; }
        public string SARGI_SAYISI { get; set; }
        public string BAGLANTI_GRUBU { get; set; }
        public string IMALAT_NORMU { get; set; }
        public string DENGELEME_SARGISI { get; set; }
        public string TETA_MUH { get; set; }
        public string SARGI_SIC { get; set; }
        public string YAG_SIC { get; set; }
        public string CALISMA_YERI_SIC { get; set; }
        public string CALISMA_YERI_YUK { get; set; }
        public string MAX_KD_SURESI { get; set; }
        public string SARIM_GERILIMI { get; set; }
        public string TOPLAM_BAKIR_AGIRLIGI { get; set; }
        public string SARGI_OLCULERI { get; set; }
        public string ACIKALAMALAR { get; set; }
        public string PROJE_NO { get; set; }
        public string SIPARIS_NO { get; set; }
        public string TASARIM_NO { get; set; }
    }
}
