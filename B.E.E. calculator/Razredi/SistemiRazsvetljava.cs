using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace B.E.E._calculator.Razredi
{
    public class SistemiRazsvetljava
    {
        

        private double sp_moc_svet { get; set; } //spec_el_moc_svetilk
        private double faktor_zmajn_osve { get; set; } //faktor_zmajnsanja_osvetlitve
        private int let_st_razsv_d { get; set; } //letno_st_razsvetljave_dan
        private int let_st_razsv_n { get; set; } //letno_st_razsvetljave_noc
        private double polnj_baterij_varn_sij { get; set; } //polnjenje_baterij_varnostnih_sijalk
        private double reg_delov_varn_sij { get; set; } //reg_delovanja_varnostnih_sijalk
        private string nac_vkl_izkl_svet { get; set; } // nacin_vklopa_izklopa_svetil
        private double fakt_upo_stavbe { get; set; } //faktor_uporabe_stavbe
        private double fakt_d_upo_stavbe { get; set; } //faktor_dnevne_uporabe_stavbe
        private string pol_transp_gradn { get; set; } //polozaj_transparentnih_gradnikov
        private double fakt_nar_osv { get; set; } //faktor_naravne_osvetlitve
        private string sis_razsvet { get; set; } // sistem_razsvetljave
        private double fakt_zman_svet_toka { get; set; } //faktor_zmanjsevanja_svetlobnega_toka
        private double dov_ener_razsv { get; set; } //dovedena_energija_razsvetljave

        private double dolzina_cone { get; set; }
        private double sirina_cone { get; set; }
        private double visi_svet_del_pov { get; set; } //visina_svetilk_nad_delovno_povrsino
        private string del_svetl_toka { get; set; } //delez_svetlobnega_toka
        private double korig_fak_obl_cone { get; set; } //korigiran_faktor_oblike_cone
        private double pov_cone_projek_osv { get; set; } //povrsina_cone_projektirana_osvetljenost
        private double osvet_del_pov { get; set; } //osvetlitev_delovnih_povrsin
        private double pov_del_pov { get; set; } //povrsina_delovnih_povrsin
        private double osvet_okol_pov { get; set; } //osvetlitev_okoliskih_povrsin
        private double fak_projek_osvet { get; set; } //faktor_projektirane_osvetlitve
        private string vrsta_svetilk { get; set; }
        private double fak_vzdr_svet { get; set; } //faktor_vzdrzevanja_svetilk
        private double energ_ucink_svet { get; set; } //energijska_ucinkovitost_svetlobe
        private double spec_moc_vgra_sve { get; set; } //spec_moc_vgrajenih_svetilk

        public SistemiRazsvetljava(
            double sp_moc_svet,
            double faktor_zmajn_osve,
            int let_st_razsv_d,
            int let_st_razsv_n,
            double polnj_baterij_varn_sij,
            double reg_delov_varn_sij,
            string nac_vkl_izkl_svet,
            double  fakt_upo_stavbe,
            double fakt_d_upo_stavbe,
            string pol_transp_gradn,
            double fakt_nar_osv,
            string sis_razsvet,
            double fakt_zman_svet_toka,
            double dov_ener_razsv,

            double dolzina_cone,
            double sirina_cone,
            double visi_svet_del_pov,
            string del_svetl_toka,
            double korig_fak_obl_cone,
            double pov_cone_projek_osv,
            double osvet_del_pov,
            double pov_del_pov,
            double osvet_okol_pov,
            double fak_projek_osvet,
            string vrsta_svetilk,
            double fak_vzdr_svet,
            double energ_ucink_svet,
            double spec_moc_vgra_sve)
        {
            this.sp_moc_svet = sp_moc_svet;
            this.faktor_zmajn_osve = faktor_zmajn_osve;
            this.let_st_razsv_d = let_st_razsv_d;
            this.let_st_razsv_n = let_st_razsv_n;
            this.polnj_baterij_varn_sij = polnj_baterij_varn_sij;
            this.reg_delov_varn_sij = reg_delov_varn_sij;
            this.nac_vkl_izkl_svet = nac_vkl_izkl_svet;
            this.fakt_upo_stavbe = fakt_upo_stavbe;
            this.fakt_d_upo_stavbe = fakt_d_upo_stavbe;
            this.pol_transp_gradn = pol_transp_gradn;
            this.fakt_nar_osv = fakt_nar_osv;
            this.sis_razsvet = sis_razsvet;
            this.fakt_zman_svet_toka = fakt_zman_svet_toka;
            this.dov_ener_razsv = dov_ener_razsv;

            this.dolzina_cone = dolzina_cone;
            this.sirina_cone = sirina_cone;
            this.visi_svet_del_pov = visi_svet_del_pov;
            this.del_svetl_toka = del_svetl_toka;
            this.korig_fak_obl_cone = korig_fak_obl_cone;
            this.pov_cone_projek_osv = pov_cone_projek_osv;
            this.osvet_del_pov = osvet_del_pov;
            this.pov_del_pov = pov_del_pov;
            this.osvet_okol_pov = osvet_okol_pov;
            this.fak_projek_osvet = fak_projek_osvet;
            this.vrsta_svetilk = vrsta_svetilk;
            this.fak_vzdr_svet = fak_vzdr_svet;
            this.energ_ucink_svet = energ_ucink_svet;
            this.spec_moc_vgra_sve = spec_moc_vgra_sve;
        }
    }
}
