using System.Collections.Generic;

namespace Aptacode.MimeTypes
{
    public static partial class MimeTypes
    {

        public static class Application
        {
            public const string Type = "application";

            public static MimeType Acad { get; } = new MimeType("application", "acad");
            public static MimeType Annodex { get; } = new MimeType("application", "annodex");
            public static MimeType Applixware { get; } = new MimeType("application", "applixware");
            public static MimeType Atom_xml { get; } = new MimeType("application", "atom+xml");
            public static MimeType Atomcat_xml { get; } = new MimeType("application", "atomcat+xml");
            public static MimeType Atomsvc_xml { get; } = new MimeType("application", "atomsvc+xml");
            public static MimeType Ccxml_xml { get; } = new MimeType("application", "ccxml+xml");
            public static MimeType Cdmi_capability { get; } = new MimeType("application", "cdmi-capability");
            public static MimeType Cdmi_container { get; } = new MimeType("application", "cdmi-container");
            public static MimeType Cdmi_domain { get; } = new MimeType("application", "cdmi-domain");
            public static MimeType Cdmi_object { get; } = new MimeType("application", "cdmi-object");
            public static MimeType Cdmi_queue { get; } = new MimeType("application", "cdmi-queue");
            public static MimeType Cu_seeme { get; } = new MimeType("application", "cu-seeme");
            public static MimeType Davmount_xml { get; } = new MimeType("application", "davmount+xml");
            public static MimeType Directx { get; } = new MimeType("application", "directx");
            public static MimeType Docbook_xml { get; } = new MimeType("application", "docbook+xml");
            public static MimeType Dssc_der { get; } = new MimeType("application", "dssc+der");
            public static MimeType Dssc_xml { get; } = new MimeType("application", "dssc+xml");
            public static MimeType Ecmascript { get; } = new MimeType("application", "ecmascript");
            public static MimeType Emma_xml { get; } = new MimeType("application", "emma+xml");
            public static MimeType Envoy { get; } = new MimeType("application", "envoy");
            public static MimeType Epub_zip { get; } = new MimeType("application", "epub+zip");
            public static MimeType Etl { get; } = new MimeType("application", "etl");
            public static MimeType Exi { get; } = new MimeType("application", "exi");
            public static MimeType Font_sfnt { get; } = new MimeType("application", "font-sfnt");
            public static MimeType Font_tdpfr { get; } = new MimeType("application", "font-tdpfr");
            public static MimeType Font_woff { get; } = new MimeType("application", "font-woff");
            public static MimeType Font_woff2 { get; } = new MimeType("application", "font-woff2");
            public static MimeType Fractals { get; } = new MimeType("application", "fractals");
            public static MimeType Fsharp_script { get; } = new MimeType("application", "fsharp-script");
            public static MimeType Futuresplash { get; } = new MimeType("application", "futuresplash");
            public static MimeType Gml_xml { get; } = new MimeType("application", "gml+xml");
            public static MimeType Gpx_xml { get; } = new MimeType("application", "gpx+xml");
            public static MimeType Gxf { get; } = new MimeType("application", "gxf");
            public static MimeType Hta { get; } = new MimeType("application", "hta");
            public static MimeType Hyperstudio { get; } = new MimeType("application", "hyperstudio");
            public static MimeType Inkml_xml { get; } = new MimeType("application", "inkml+xml");
            public static MimeType Internet_property_stream { get; } = new MimeType("application", "internet-property-stream");
            public static MimeType Ipfix { get; } = new MimeType("application", "ipfix");
            public static MimeType Java_archive { get; } = new MimeType("application", "java-archive");
            public static MimeType Javascript { get; } = new MimeType("application", "javascript");
            public static MimeType Java_serialized_object { get; } = new MimeType("application", "java-serialized-object");
            public static MimeType Java_vm { get; } = new MimeType("application", "java-vm");
            public static MimeType Json { get; } = new MimeType("application", "json");
            public static MimeType Jsonml_json { get; } = new MimeType("application", "jsonml+json");
            public static MimeType Liquidmotion { get; } = new MimeType("application", "liquidmotion");
            public static MimeType Lost_xml { get; } = new MimeType("application", "lost+xml");
            public static MimeType Mac_binhex40 { get; } = new MimeType("application", "mac-binhex40");
            public static MimeType Mac_compactpro { get; } = new MimeType("application", "mac-compactpro");
            public static MimeType Mads_xml { get; } = new MimeType("application", "mads+xml");
            public static MimeType Marc { get; } = new MimeType("application", "marc");
            public static MimeType Marcxml_xml { get; } = new MimeType("application", "marcxml+xml");
            public static MimeType Mathematica { get; } = new MimeType("application", "mathematica");
            public static MimeType Mathml_xml { get; } = new MimeType("application", "mathml+xml");
            public static MimeType Mbox { get; } = new MimeType("application", "mbox");
            public static MimeType Mediaservercontrol_xml { get; } = new MimeType("application", "mediaservercontrol+xml");
            public static MimeType Metalink_xml { get; } = new MimeType("application", "metalink+xml");
            public static MimeType Metalink4_xml { get; } = new MimeType("application", "metalink4+xml");
            public static MimeType Mets_xml { get; } = new MimeType("application", "mets+xml");
            public static MimeType Mods_xml { get; } = new MimeType("application", "mods+xml");
            public static MimeType Mp21 { get; } = new MimeType("application", "mp21");
            public static MimeType Mp4 { get; } = new MimeType("application", "mp4");
            public static MimeType Mpeg { get; } = new MimeType("application", "mpeg");
            public static MimeType Msaccess { get; } = new MimeType("application", "msaccess");
            public static MimeType Msaccess_addin { get; } = new MimeType("application", "msaccess.addin");
            public static MimeType Msaccess_cab { get; } = new MimeType("application", "msaccess.cab");
            public static MimeType Msaccess_ftemplate { get; } = new MimeType("application", "msaccess.ftemplate");
            public static MimeType Msaccess_runtime { get; } = new MimeType("application", "msaccess.runtime");
            public static MimeType Msaccess_webapplication { get; } = new MimeType("application", "msaccess.webapplication");
            public static MimeType Ms_vsi { get; } = new MimeType("application", "ms-vsi");
            public static MimeType Msword { get; } = new MimeType("application", "msword");
            public static MimeType Mxf { get; } = new MimeType("application", "mxf");
            public static MimeType Octet_stream { get; } = new MimeType("application", "octet-stream");
            public static MimeType Oda { get; } = new MimeType("application", "oda");
            public static MimeType Oebps_package_xml { get; } = new MimeType("application", "oebps-package+xml");
            public static MimeType Ogg { get; } = new MimeType("application", "ogg");
            public static MimeType Olescript { get; } = new MimeType("application", "olescript");
            public static MimeType Omdoc_xml { get; } = new MimeType("application", "omdoc+xml");
            public static MimeType Onenote { get; } = new MimeType("application", "onenote");
            public static MimeType Opensearchdescription_xml { get; } = new MimeType("application", "opensearchdescription+xml");
            public static MimeType Oxps { get; } = new MimeType("application", "oxps");
            public static MimeType Patch_ops_error_xml { get; } = new MimeType("application", "patch-ops-error+xml");
            public static MimeType Pdf { get; } = new MimeType("application", "pdf");
            public static MimeType Pgp_encrypted { get; } = new MimeType("application", "pgp-encrypted");
            public static MimeType Pgp_signature { get; } = new MimeType("application", "pgp-signature");
            public static MimeType Pics_rules { get; } = new MimeType("application", "pics-rules");
            public static MimeType Pkcs10 { get; } = new MimeType("application", "pkcs10");
            public static MimeType Pkcs7_mime { get; } = new MimeType("application", "pkcs7-mime");
            public static MimeType Pkcs7_signature { get; } = new MimeType("application", "pkcs7-signature");
            public static MimeType Pkcs8 { get; } = new MimeType("application", "pkcs8");
            public static MimeType Pkix_attr_cert { get; } = new MimeType("application", "pkix-attr-cert");
            public static MimeType Pkix_cert { get; } = new MimeType("application", "pkix-cert");
            public static MimeType Pkixcmp { get; } = new MimeType("application", "pkixcmp");
            public static MimeType Pkix_crl { get; } = new MimeType("application", "pkix-crl");
            public static MimeType Pkix_pkipath { get; } = new MimeType("application", "pkix-pkipath");
            public static MimeType Pls_xml { get; } = new MimeType("application", "pls+xml");
            public static MimeType Postscript { get; } = new MimeType("application", "postscript");
            public static MimeType PowerShell { get; } = new MimeType("application", "PowerShell");
            public static MimeType Prs_cww { get; } = new MimeType("application", "prs.cww");
            public static MimeType Pskc_xml { get; } = new MimeType("application", "pskc+xml");
            public static MimeType Rat_file { get; } = new MimeType("application", "rat-file");
            public static MimeType Rdf_xml { get; } = new MimeType("application", "rdf+xml");
            public static MimeType Reginfo_xml { get; } = new MimeType("application", "reginfo+xml");
            public static MimeType Relax_ng_compact_syntax { get; } = new MimeType("application", "relax-ng-compact-syntax");
            public static MimeType Resource_lists_xml { get; } = new MimeType("application", "resource-lists+xml");
            public static MimeType Resource_lists_diff_xml { get; } = new MimeType("application", "resource-lists-diff+xml");
            public static MimeType Rls_services_xml { get; } = new MimeType("application", "rls-services+xml");
            public static MimeType Rpki_ghostbusters { get; } = new MimeType("application", "rpki-ghostbusters");
            public static MimeType Rpki_manifest { get; } = new MimeType("application", "rpki-manifest");
            public static MimeType Rpki_roa { get; } = new MimeType("application", "rpki-roa");
            public static MimeType Rsd_xml { get; } = new MimeType("application", "rsd+xml");
            public static MimeType Rss_xml { get; } = new MimeType("application", "rss+xml");
            public static MimeType Rtf { get; } = new MimeType("application", "rtf");
            public static MimeType Sbml_xml { get; } = new MimeType("application", "sbml+xml");
            public static MimeType Scvp_cv_request { get; } = new MimeType("application", "scvp-cv-request");
            public static MimeType Scvp_cv_response { get; } = new MimeType("application", "scvp-cv-response");
            public static MimeType Scvp_vp_request { get; } = new MimeType("application", "scvp-vp-request");
            public static MimeType Scvp_vp_response { get; } = new MimeType("application", "scvp-vp-response");
            public static MimeType Sdp { get; } = new MimeType("application", "sdp");
            public static MimeType Set_payment_initiation { get; } = new MimeType("application", "set-payment-initiation");
            public static MimeType Set_registration_initiation { get; } = new MimeType("application", "set-registration-initiation");
            public static MimeType Shf_xml { get; } = new MimeType("application", "shf+xml");
            public static MimeType Smil_xml { get; } = new MimeType("application", "smil+xml");
            public static MimeType Sparql_query { get; } = new MimeType("application", "sparql-query");
            public static MimeType Sparql_results_xml { get; } = new MimeType("application", "sparql-results+xml");
            public static MimeType Srgs { get; } = new MimeType("application", "srgs");
            public static MimeType Srgs_xml { get; } = new MimeType("application", "srgs+xml");
            public static MimeType Sru_xml { get; } = new MimeType("application", "sru+xml");
            public static MimeType Ssdl_xml { get; } = new MimeType("application", "ssdl+xml");
            public static MimeType Ssml_xml { get; } = new MimeType("application", "ssml+xml");
            public static MimeType Step { get; } = new MimeType("application", "step");
            public static MimeType Streamingmedia { get; } = new MimeType("application", "streamingmedia");
            public static MimeType Tei_xml { get; } = new MimeType("application", "tei+xml");
            public static MimeType Thraud_xml { get; } = new MimeType("application", "thraud+xml");
            public static MimeType Timestamped_data { get; } = new MimeType("application", "timestamped-data");
            public static MimeType Vnd_3gpp_pic_bw_large { get; } = new MimeType("application", "vnd.3gpp.pic-bw-large");
            public static MimeType Vnd_3gpp_pic_bw_small { get; } = new MimeType("application", "vnd.3gpp.pic-bw-small");
            public static MimeType Vnd_3gpp_pic_bw_var { get; } = new MimeType("application", "vnd.3gpp.pic-bw-var");
            public static MimeType Vnd_3gpp2_tcap { get; } = new MimeType("application", "vnd.3gpp2.tcap");
            public static MimeType Vnd_3m_post_it_notes { get; } = new MimeType("application", "vnd.3m.post-it-notes");
            public static MimeType Vnd_accpac_simply_aso { get; } = new MimeType("application", "vnd.accpac.simply.aso");
            public static MimeType Vnd_accpac_simply_imp { get; } = new MimeType("application", "vnd.accpac.simply.imp");
            public static MimeType Vnd_acucobol { get; } = new MimeType("application", "vnd.acucobol");
            public static MimeType Vnd_acucorp { get; } = new MimeType("application", "vnd.acucorp");
            public static MimeType Vnd_adobe_air_application_installer_package_zip { get; } = new MimeType("application", "vnd.adobe.air-application-installer-package+zip");
            public static MimeType Vnd_adobe_formscentral_fcdt { get; } = new MimeType("application", "vnd.adobe.formscentral.fcdt");
            public static MimeType Vnd_adobe_fxp { get; } = new MimeType("application", "vnd.adobe.fxp");
            public static MimeType Vnd_adobe_xdp_xml { get; } = new MimeType("application", "vnd.adobe.xdp+xml");
            public static MimeType Vnd_adobe_xfdf { get; } = new MimeType("application", "vnd.adobe.xfdf");
            public static MimeType Vnd_ahead_space { get; } = new MimeType("application", "vnd.ahead.space");
            public static MimeType Vnd_airzip_filesecure_azf { get; } = new MimeType("application", "vnd.airzip.filesecure.azf");
            public static MimeType Vnd_airzip_filesecure_azs { get; } = new MimeType("application", "vnd.airzip.filesecure.azs");
            public static MimeType Vnd_amazon_ebook { get; } = new MimeType("application", "vnd.amazon.ebook");
            public static MimeType Vnd_americandynamics_acc { get; } = new MimeType("application", "vnd.americandynamics.acc");
            public static MimeType Vnd_amiga_ami { get; } = new MimeType("application", "vnd.amiga.ami");
            public static MimeType Vnd_android_package_archive { get; } = new MimeType("application", "vnd.android.package-archive");
            public static MimeType Vnd_anser_web_certificate_issue_initiation { get; } = new MimeType("application", "vnd.anser-web-certificate-issue-initiation");
            public static MimeType Vnd_anser_web_funds_transfer_initiation { get; } = new MimeType("application", "vnd.anser-web-funds-transfer-initiation");
            public static MimeType Vnd_antix_game_component { get; } = new MimeType("application", "vnd.antix.game-component");
            public static MimeType Vnd_apple_installer_xml { get; } = new MimeType("application", "vnd.apple.installer+xml");
            public static MimeType Vnd_apple_mpegurl { get; } = new MimeType("application", "vnd.apple.mpegurl");
            public static MimeType Vnd_aristanetworks_swi { get; } = new MimeType("application", "vnd.aristanetworks.swi");
            public static MimeType Vnd_astraea_software_iota { get; } = new MimeType("application", "vnd.astraea-software.iota");
            public static MimeType Vnd_audiograph { get; } = new MimeType("application", "vnd.audiograph");
            public static MimeType Vnd_blueice_multipass { get; } = new MimeType("application", "vnd.blueice.multipass");
            public static MimeType Vnd_bmi { get; } = new MimeType("application", "vnd.bmi");
            public static MimeType Vnd_businessobjects { get; } = new MimeType("application", "vnd.businessobjects");
            public static MimeType Vnd_chemdraw_xml { get; } = new MimeType("application", "vnd.chemdraw+xml");
            public static MimeType Vnd_chipnuts_karaoke_mmd { get; } = new MimeType("application", "vnd.chipnuts.karaoke-mmd");
            public static MimeType Vnd_cinderella { get; } = new MimeType("application", "vnd.cinderella");
            public static MimeType Vnd_claymore { get; } = new MimeType("application", "vnd.claymore");
            public static MimeType Vnd_cloanto_rp9 { get; } = new MimeType("application", "vnd.cloanto.rp9");
            public static MimeType Vnd_clonk_c4group { get; } = new MimeType("application", "vnd.clonk.c4group");
            public static MimeType Vnd_cluetrust_cartomobile_config { get; } = new MimeType("application", "vnd.cluetrust.cartomobile-config");
            public static MimeType Vnd_cluetrust_cartomobile_config_pkg { get; } = new MimeType("application", "vnd.cluetrust.cartomobile-config-pkg");
            public static MimeType Vnd_commonspace { get; } = new MimeType("application", "vnd.commonspace");
            public static MimeType Vnd_contact_cmsg { get; } = new MimeType("application", "vnd.contact.cmsg");
            public static MimeType Vnd_cosmocaller { get; } = new MimeType("application", "vnd.cosmocaller");
            public static MimeType Vnd_crick_clicker { get; } = new MimeType("application", "vnd.crick.clicker");
            public static MimeType Vnd_crick_clicker_keyboard { get; } = new MimeType("application", "vnd.crick.clicker.keyboard");
            public static MimeType Vnd_crick_clicker_palette { get; } = new MimeType("application", "vnd.crick.clicker.palette");
            public static MimeType Vnd_crick_clicker_template { get; } = new MimeType("application", "vnd.crick.clicker.template");
            public static MimeType Vnd_crick_clicker_wordbank { get; } = new MimeType("application", "vnd.crick.clicker.wordbank");
            public static MimeType Vnd_criticaltools_wbs_xml { get; } = new MimeType("application", "vnd.criticaltools.wbs+xml");
            public static MimeType Vnd_ctc_posml { get; } = new MimeType("application", "vnd.ctc-posml");
            public static MimeType Vnd_cups_ppd { get; } = new MimeType("application", "vnd.cups-ppd");
            public static MimeType Vnd_curl_car { get; } = new MimeType("application", "vnd.curl.car");
            public static MimeType Vnd_curl_pcurl { get; } = new MimeType("application", "vnd.curl.pcurl");
            public static MimeType Vnd_dart { get; } = new MimeType("application", "vnd.dart");
            public static MimeType Vnd_data_vision_rdz { get; } = new MimeType("application", "vnd.data-vision.rdz");
            public static MimeType Vnd_dece_data { get; } = new MimeType("application", "vnd.dece.data");
            public static MimeType Vnd_dece_ttml_xml { get; } = new MimeType("application", "vnd.dece.ttml+xml");
            public static MimeType Vnd_dece_unspecified { get; } = new MimeType("application", "vnd.dece.unspecified");
            public static MimeType Vnd_dece_zip { get; } = new MimeType("application", "vnd.dece.zip");
            public static MimeType Vnd_denovo_fcselayout_link { get; } = new MimeType("application", "vnd.denovo.fcselayout-link");
            public static MimeType Vnd_dna { get; } = new MimeType("application", "vnd.dna");
            public static MimeType Vnd_dolby_mlp { get; } = new MimeType("application", "vnd.dolby.mlp");
            public static MimeType Vnd_dpgraph { get; } = new MimeType("application", "vnd.dpgraph");
            public static MimeType Vnd_dreamfactory { get; } = new MimeType("application", "vnd.dreamfactory");
            public static MimeType Vnd_ds_keypoint { get; } = new MimeType("application", "vnd.ds-keypoint");
            public static MimeType Vnd_dvb_ait { get; } = new MimeType("application", "vnd.dvb.ait");
            public static MimeType Vnd_dvb_service { get; } = new MimeType("application", "vnd.dvb.service");
            public static MimeType Vnd_dynageo { get; } = new MimeType("application", "vnd.dynageo");
            public static MimeType Vnd_ecowin_chart { get; } = new MimeType("application", "vnd.ecowin.chart");
            public static MimeType Vnd_enliven { get; } = new MimeType("application", "vnd.enliven");
            public static MimeType Vnd_epson_esf { get; } = new MimeType("application", "vnd.epson.esf");
            public static MimeType Vnd_epson_msf { get; } = new MimeType("application", "vnd.epson.msf");
            public static MimeType Vnd_epson_quickanime { get; } = new MimeType("application", "vnd.epson.quickanime");
            public static MimeType Vnd_epson_salt { get; } = new MimeType("application", "vnd.epson.salt");
            public static MimeType Vnd_epson_ssf { get; } = new MimeType("application", "vnd.epson.ssf");
            public static MimeType Vnd_eszigno3_xml { get; } = new MimeType("application", "vnd.eszigno3+xml");
            public static MimeType Vnd_ezpix_album { get; } = new MimeType("application", "vnd.ezpix-album");
            public static MimeType Vnd_ezpix_package { get; } = new MimeType("application", "vnd.ezpix-package");
            public static MimeType Vnd_fdf { get; } = new MimeType("application", "vnd.fdf");
            public static MimeType Vnd_fdsn_mseed { get; } = new MimeType("application", "vnd.fdsn.mseed");
            public static MimeType Vnd_fdsn_seed { get; } = new MimeType("application", "vnd.fdsn.seed");
            public static MimeType Vnd_flographit { get; } = new MimeType("application", "vnd.flographit");
            public static MimeType Vnd_fluxtime_clip { get; } = new MimeType("application", "vnd.fluxtime.clip");
            public static MimeType Vnd_framemaker { get; } = new MimeType("application", "vnd.framemaker");
            public static MimeType Vnd_frogans_fnc { get; } = new MimeType("application", "vnd.frogans.fnc");
            public static MimeType Vnd_frogans_ltf { get; } = new MimeType("application", "vnd.frogans.ltf");
            public static MimeType Vnd_fsc_weblaunch { get; } = new MimeType("application", "vnd.fsc.weblaunch");
            public static MimeType Vnd_fujitsu_oasys { get; } = new MimeType("application", "vnd.fujitsu.oasys");
            public static MimeType Vnd_fujitsu_oasys2 { get; } = new MimeType("application", "vnd.fujitsu.oasys2");
            public static MimeType Vnd_fujitsu_oasys3 { get; } = new MimeType("application", "vnd.fujitsu.oasys3");
            public static MimeType Vnd_fujitsu_oasysgp { get; } = new MimeType("application", "vnd.fujitsu.oasysgp");
            public static MimeType Vnd_fujitsu_oasysprs { get; } = new MimeType("application", "vnd.fujitsu.oasysprs");
            public static MimeType Vnd_fujixerox_ddd { get; } = new MimeType("application", "vnd.fujixerox.ddd");
            public static MimeType Vnd_fujixerox_docuworks { get; } = new MimeType("application", "vnd.fujixerox.docuworks");
            public static MimeType Vnd_fujixerox_docuworks_binder { get; } = new MimeType("application", "vnd.fujixerox.docuworks.binder");
            public static MimeType Vnd_fuzzysheet { get; } = new MimeType("application", "vnd.fuzzysheet");
            public static MimeType Vnd_genomatix_tuxedo { get; } = new MimeType("application", "vnd.genomatix.tuxedo");
            public static MimeType Vnd_geogebra_file { get; } = new MimeType("application", "vnd.geogebra.file");
            public static MimeType Vnd_geogebra_tool { get; } = new MimeType("application", "vnd.geogebra.tool");
            public static MimeType Vnd_geometry_explorer { get; } = new MimeType("application", "vnd.geometry-explorer");
            public static MimeType Vnd_geonext { get; } = new MimeType("application", "vnd.geonext");
            public static MimeType Vnd_geoplan { get; } = new MimeType("application", "vnd.geoplan");
            public static MimeType Vnd_geospace { get; } = new MimeType("application", "vnd.geospace");
            public static MimeType Vnd_gmx { get; } = new MimeType("application", "vnd.gmx");
            public static MimeType Vnd_google_earth_kml_xml { get; } = new MimeType("application", "vnd.google-earth.kml+xml");
            public static MimeType Vnd_google_earth_kmz { get; } = new MimeType("application", "vnd.google-earth.kmz");
            public static MimeType Vnd_grafeq { get; } = new MimeType("application", "vnd.grafeq");
            public static MimeType Vnd_groove_account { get; } = new MimeType("application", "vnd.groove-account");
            public static MimeType Vnd_groove_help { get; } = new MimeType("application", "vnd.groove-help");
            public static MimeType Vnd_groove_identity_message { get; } = new MimeType("application", "vnd.groove-identity-message");
            public static MimeType Vnd_groove_injector { get; } = new MimeType("application", "vnd.groove-injector");
            public static MimeType Vnd_groove_tool_message { get; } = new MimeType("application", "vnd.groove-tool-message");
            public static MimeType Vnd_groove_tool_template { get; } = new MimeType("application", "vnd.groove-tool-template");
            public static MimeType Vnd_groove_vcard { get; } = new MimeType("application", "vnd.groove-vcard");
            public static MimeType Vnd_hal_xml { get; } = new MimeType("application", "vnd.hal+xml");
            public static MimeType Vnd_handheld_entertainment_xml { get; } = new MimeType("application", "vnd.handheld-entertainment+xml");
            public static MimeType Vnd_hbci { get; } = new MimeType("application", "vnd.hbci");
            public static MimeType Vnd_hhe_lesson_player { get; } = new MimeType("application", "vnd.hhe.lesson-player");
            public static MimeType Vnd_hp_hpgl { get; } = new MimeType("application", "vnd.hp-hpgl");
            public static MimeType Vnd_hp_hpid { get; } = new MimeType("application", "vnd.hp-hpid");
            public static MimeType Vnd_hp_hps { get; } = new MimeType("application", "vnd.hp-hps");
            public static MimeType Vnd_hp_jlyt { get; } = new MimeType("application", "vnd.hp-jlyt");
            public static MimeType Vnd_hp_pcl { get; } = new MimeType("application", "vnd.hp-pcl");
            public static MimeType Vnd_hp_pclxl { get; } = new MimeType("application", "vnd.hp-pclxl");
            public static MimeType Vnd_hydrostatix_sof_data { get; } = new MimeType("application", "vnd.hydrostatix.sof-data");
            public static MimeType Vnd_ibm_minipay { get; } = new MimeType("application", "vnd.ibm.minipay");
            public static MimeType Vnd_ibm_modcap { get; } = new MimeType("application", "vnd.ibm.modcap");
            public static MimeType Vnd_ibm_rights_management { get; } = new MimeType("application", "vnd.ibm.rights-management");
            public static MimeType Vnd_ibm_secure_container { get; } = new MimeType("application", "vnd.ibm.secure-container");
            public static MimeType Vnd_iccprofile { get; } = new MimeType("application", "vnd.iccprofile");
            public static MimeType Vnd_igloader { get; } = new MimeType("application", "vnd.igloader");
            public static MimeType Vnd_immervision_ivp { get; } = new MimeType("application", "vnd.immervision-ivp");
            public static MimeType Vnd_immervision_ivu { get; } = new MimeType("application", "vnd.immervision-ivu");
            public static MimeType Vnd_insors_igm { get; } = new MimeType("application", "vnd.insors.igm");
            public static MimeType Vnd_intercon_formnet { get; } = new MimeType("application", "vnd.intercon.formnet");
            public static MimeType Vnd_intergeo { get; } = new MimeType("application", "vnd.intergeo");
            public static MimeType Vnd_intu_qbo { get; } = new MimeType("application", "vnd.intu.qbo");
            public static MimeType Vnd_intu_qfx { get; } = new MimeType("application", "vnd.intu.qfx");
            public static MimeType Vnd_ipunplugged_rcprofile { get; } = new MimeType("application", "vnd.ipunplugged.rcprofile");
            public static MimeType Vnd_irepository_package_xml { get; } = new MimeType("application", "vnd.irepository.package+xml");
            public static MimeType Vnd_isac_fcs { get; } = new MimeType("application", "vnd.isac.fcs");
            public static MimeType Vnd_is_xpr { get; } = new MimeType("application", "vnd.is-xpr");
            public static MimeType Vnd_jam { get; } = new MimeType("application", "vnd.jam");
            public static MimeType Vnd_jcp_javame_midlet_rms { get; } = new MimeType("application", "vnd.jcp.javame.midlet-rms");
            public static MimeType Vnd_jisp { get; } = new MimeType("application", "vnd.jisp");
            public static MimeType Vnd_joost_joda_archive { get; } = new MimeType("application", "vnd.joost.joda-archive");
            public static MimeType Vnd_kahootz { get; } = new MimeType("application", "vnd.kahootz");
            public static MimeType Vnd_kde_karbon { get; } = new MimeType("application", "vnd.kde.karbon");
            public static MimeType Vnd_kde_kchart { get; } = new MimeType("application", "vnd.kde.kchart");
            public static MimeType Vnd_kde_kformula { get; } = new MimeType("application", "vnd.kde.kformula");
            public static MimeType Vnd_kde_kivio { get; } = new MimeType("application", "vnd.kde.kivio");
            public static MimeType Vnd_kde_kontour { get; } = new MimeType("application", "vnd.kde.kontour");
            public static MimeType Vnd_kde_kpresenter { get; } = new MimeType("application", "vnd.kde.kpresenter");
            public static MimeType Vnd_kde_kspread { get; } = new MimeType("application", "vnd.kde.kspread");
            public static MimeType Vnd_kde_kword { get; } = new MimeType("application", "vnd.kde.kword");
            public static MimeType Vnd_kenameaapp { get; } = new MimeType("application", "vnd.kenameaapp");
            public static MimeType Vnd_kidspiration { get; } = new MimeType("application", "vnd.kidspiration");
            public static MimeType Vnd_kinar { get; } = new MimeType("application", "vnd.kinar");
            public static MimeType Vnd_koan { get; } = new MimeType("application", "vnd.koan");
            public static MimeType Vnd_kodak_descriptor { get; } = new MimeType("application", "vnd.kodak-descriptor");
            public static MimeType Vnd_las_las_xml { get; } = new MimeType("application", "vnd.las.las+xml");
            public static MimeType Vnd_llamagraphics_life_balance_desktop { get; } = new MimeType("application", "vnd.llamagraphics.life-balance.desktop");
            public static MimeType Vnd_llamagraphics_life_balance_exchange_xml { get; } = new MimeType("application", "vnd.llamagraphics.life-balance.exchange+xml");
            public static MimeType Vnd_lotus_1_2_3 { get; } = new MimeType("application", "vnd.lotus-1-2-3");
            public static MimeType Vnd_lotus_approach { get; } = new MimeType("application", "vnd.lotus-approach");
            public static MimeType Vnd_lotus_freelance { get; } = new MimeType("application", "vnd.lotus-freelance");
            public static MimeType Vnd_lotus_notes { get; } = new MimeType("application", "vnd.lotus-notes");
            public static MimeType Vnd_lotus_organizer { get; } = new MimeType("application", "vnd.lotus-organizer");
            public static MimeType Vnd_lotus_screencam { get; } = new MimeType("application", "vnd.lotus-screencam");
            public static MimeType Vnd_lotus_wordpro { get; } = new MimeType("application", "vnd.lotus-wordpro");
            public static MimeType Vnd_macports_portpkg { get; } = new MimeType("application", "vnd.macports.portpkg");
            public static MimeType Vnd_mcd { get; } = new MimeType("application", "vnd.mcd");
            public static MimeType Vnd_medcalcdata { get; } = new MimeType("application", "vnd.medcalcdata");
            public static MimeType Vnd_mediastation_cdkey { get; } = new MimeType("application", "vnd.mediastation.cdkey");
            public static MimeType Vnd_mfer { get; } = new MimeType("application", "vnd.mfer");
            public static MimeType Vnd_mfmp { get; } = new MimeType("application", "vnd.mfmp");
            public static MimeType Vnd_micrografx_flo { get; } = new MimeType("application", "vnd.micrografx.flo");
            public static MimeType Vnd_micrografx_igx { get; } = new MimeType("application", "vnd.micrografx.igx");
            public static MimeType Vnd_microsoft_portable_executable { get; } = new MimeType("application", "vnd.microsoft.portable-executable");
            public static MimeType Vnd_mif { get; } = new MimeType("application", "vnd.mif");
            public static MimeType Vnd_mobius_daf { get; } = new MimeType("application", "vnd.mobius.daf");
            public static MimeType Vnd_mobius_dis { get; } = new MimeType("application", "vnd.mobius.dis");
            public static MimeType Vnd_mobius_mbk { get; } = new MimeType("application", "vnd.mobius.mbk");
            public static MimeType Vnd_mobius_mqy { get; } = new MimeType("application", "vnd.mobius.mqy");
            public static MimeType Vnd_mobius_msl { get; } = new MimeType("application", "vnd.mobius.msl");
            public static MimeType Vnd_mobius_plc { get; } = new MimeType("application", "vnd.mobius.plc");
            public static MimeType Vnd_mobius_txf { get; } = new MimeType("application", "vnd.mobius.txf");
            public static MimeType Vnd_mophun_application { get; } = new MimeType("application", "vnd.mophun.application");
            public static MimeType Vnd_mophun_certificate { get; } = new MimeType("application", "vnd.mophun.certificate");
            public static MimeType Vnd_mozilla_xul_xml { get; } = new MimeType("application", "vnd.mozilla.xul+xml");
            public static MimeType Vnd_ms_artgalry { get; } = new MimeType("application", "vnd.ms-artgalry");
            public static MimeType Vnd_ms_cab_compressed { get; } = new MimeType("application", "vnd.ms-cab-compressed");
            public static MimeType Vnd_mseq { get; } = new MimeType("application", "vnd.mseq");
            public static MimeType Vnd_ms_excel { get; } = new MimeType("application", "vnd.ms-excel");
            public static MimeType Vnd_ms_excel_addin_macroenabled_12 { get; } = new MimeType("application", "vnd.ms-excel.addin.macroenabled.12");
            public static MimeType Vnd_ms_excel_addin_macroEnabled_12 { get; } = new MimeType("application", "vnd.ms-excel.addin.macroEnabled.12");
            public static MimeType Vnd_ms_excel_sheet_binary_macroenabled_12 { get; } = new MimeType("application", "vnd.ms-excel.sheet.binary.macroenabled.12");
            public static MimeType Vnd_ms_excel_sheet_binary_macroEnabled_12 { get; } = new MimeType("application", "vnd.ms-excel.sheet.binary.macroEnabled.12");
            public static MimeType Vnd_ms_excel_sheet_macroenabled_12 { get; } = new MimeType("application", "vnd.ms-excel.sheet.macroenabled.12");
            public static MimeType Vnd_ms_excel_sheet_macroEnabled_12 { get; } = new MimeType("application", "vnd.ms-excel.sheet.macroEnabled.12");
            public static MimeType Vnd_ms_excel_template_macroenabled_12 { get; } = new MimeType("application", "vnd.ms-excel.template.macroenabled.12");
            public static MimeType Vnd_ms_excel_template_macroEnabled_12 { get; } = new MimeType("application", "vnd.ms-excel.template.macroEnabled.12");
            public static MimeType Vnd_ms_fontobject { get; } = new MimeType("application", "vnd.ms-fontobject");
            public static MimeType Vnd_ms_htmlhelp { get; } = new MimeType("application", "vnd.ms-htmlhelp");
            public static MimeType Vnd_ms_ims { get; } = new MimeType("application", "vnd.ms-ims");
            public static MimeType Vnd_ms_lrm { get; } = new MimeType("application", "vnd.ms-lrm");
            public static MimeType Vnd_ms_mediapackage { get; } = new MimeType("application", "vnd.ms-mediapackage");
            public static MimeType Vnd_ms_office_calx { get; } = new MimeType("application", "vnd.ms-office.calx");
            public static MimeType Vnd_ms_officetheme { get; } = new MimeType("application", "vnd.ms-officetheme");
            public static MimeType Vnd_ms_outlook { get; } = new MimeType("application", "vnd.ms-outlook");
            public static MimeType Vnd_ms_pki_certstore { get; } = new MimeType("application", "vnd.ms-pki.certstore");
            public static MimeType Vnd_ms_pki_pko { get; } = new MimeType("application", "vnd.ms-pki.pko");
            public static MimeType Vnd_ms_pki_seccat { get; } = new MimeType("application", "vnd.ms-pki.seccat");
            public static MimeType Vnd_ms_pki_stl { get; } = new MimeType("application", "vnd.ms-pki.stl");
            public static MimeType Vnd_ms_powerpoint { get; } = new MimeType("application", "vnd.ms-powerpoint");
            public static MimeType Vnd_ms_powerpoint_addin_macroenabled_12 { get; } = new MimeType("application", "vnd.ms-powerpoint.addin.macroenabled.12");
            public static MimeType Vnd_ms_powerpoint_addin_macroEnabled_12 { get; } = new MimeType("application", "vnd.ms-powerpoint.addin.macroEnabled.12");
            public static MimeType Vnd_ms_powerpoint_presentation_macroenabled_12 { get; } = new MimeType("application", "vnd.ms-powerpoint.presentation.macroenabled.12");
            public static MimeType Vnd_ms_powerpoint_presentation_macroEnabled_12 { get; } = new MimeType("application", "vnd.ms-powerpoint.presentation.macroEnabled.12");
            public static MimeType Vnd_ms_powerpoint_slide_macroenabled_12 { get; } = new MimeType("application", "vnd.ms-powerpoint.slide.macroenabled.12");
            public static MimeType Vnd_ms_powerpoint_slide_macroEnabled_12 { get; } = new MimeType("application", "vnd.ms-powerpoint.slide.macroEnabled.12");
            public static MimeType Vnd_ms_powerpoint_slideshow_macroenabled_12 { get; } = new MimeType("application", "vnd.ms-powerpoint.slideshow.macroenabled.12");
            public static MimeType Vnd_ms_powerpoint_slideshow_macroEnabled_12 { get; } = new MimeType("application", "vnd.ms-powerpoint.slideshow.macroEnabled.12");
            public static MimeType Vnd_ms_powerpoint_template_macroenabled_12 { get; } = new MimeType("application", "vnd.ms-powerpoint.template.macroenabled.12");
            public static MimeType Vnd_ms_powerpoint_template_macroEnabled_12 { get; } = new MimeType("application", "vnd.ms-powerpoint.template.macroEnabled.12");
            public static MimeType Vnd_ms_project { get; } = new MimeType("application", "vnd.ms-project");
            public static MimeType Vnd_ms_visio_viewer { get; } = new MimeType("application", "vnd.ms-visio.viewer");
            public static MimeType Vnd_ms_word_document_macroenabled_12 { get; } = new MimeType("application", "vnd.ms-word.document.macroenabled.12");
            public static MimeType Vnd_ms_word_document_macroEnabled_12 { get; } = new MimeType("application", "vnd.ms-word.document.macroEnabled.12");
            public static MimeType Vnd_ms_word_template_macroenabled_12 { get; } = new MimeType("application", "vnd.ms-word.template.macroenabled.12");
            public static MimeType Vnd_ms_word_template_macroEnabled_12 { get; } = new MimeType("application", "vnd.ms-word.template.macroEnabled.12");
            public static MimeType Vnd_ms_works { get; } = new MimeType("application", "vnd.ms-works");
            public static MimeType Vnd_ms_wpl { get; } = new MimeType("application", "vnd.ms-wpl");
            public static MimeType Vnd_ms_xpsdocument { get; } = new MimeType("application", "vnd.ms-xpsdocument");
            public static MimeType Vnd_musician { get; } = new MimeType("application", "vnd.musician");
            public static MimeType Vnd_muvee_style { get; } = new MimeType("application", "vnd.muvee.style");
            public static MimeType Vnd_mynfc { get; } = new MimeType("application", "vnd.mynfc");
            public static MimeType Vnd_neurolanguage_nlu { get; } = new MimeType("application", "vnd.neurolanguage.nlu");
            public static MimeType Vnd_nitf { get; } = new MimeType("application", "vnd.nitf");
            public static MimeType Vnd_noblenet_directory { get; } = new MimeType("application", "vnd.noblenet-directory");
            public static MimeType Vnd_noblenet_sealer { get; } = new MimeType("application", "vnd.noblenet-sealer");
            public static MimeType Vnd_noblenet_web { get; } = new MimeType("application", "vnd.noblenet-web");
            public static MimeType Vnd_nokia_n_gage_data { get; } = new MimeType("application", "vnd.nokia.n-gage.data");
            public static MimeType Vnd_nokia_n_gage_symbian_install { get; } = new MimeType("application", "vnd.nokia.n-gage.symbian.install");
            public static MimeType Vnd_nokia_radio_preset { get; } = new MimeType("application", "vnd.nokia.radio-preset");
            public static MimeType Vnd_nokia_radio_presets { get; } = new MimeType("application", "vnd.nokia.radio-presets");
            public static MimeType Vnd_novadigm_edm { get; } = new MimeType("application", "vnd.novadigm.edm");
            public static MimeType Vnd_novadigm_edx { get; } = new MimeType("application", "vnd.novadigm.edx");
            public static MimeType Vnd_novadigm_ext { get; } = new MimeType("application", "vnd.novadigm.ext");
            public static MimeType Vnd_oasis_opendocument_chart { get; } = new MimeType("application", "vnd.oasis.opendocument.chart");
            public static MimeType Vnd_oasis_opendocument_chart_template { get; } = new MimeType("application", "vnd.oasis.opendocument.chart-template");
            public static MimeType Vnd_oasis_opendocument_database { get; } = new MimeType("application", "vnd.oasis.opendocument.database");
            public static MimeType Vnd_oasis_opendocument_formula { get; } = new MimeType("application", "vnd.oasis.opendocument.formula");
            public static MimeType Vnd_oasis_opendocument_formula_template { get; } = new MimeType("application", "vnd.oasis.opendocument.formula-template");
            public static MimeType Vnd_oasis_opendocument_graphics { get; } = new MimeType("application", "vnd.oasis.opendocument.graphics");
            public static MimeType Vnd_oasis_opendocument_graphics_template { get; } = new MimeType("application", "vnd.oasis.opendocument.graphics-template");
            public static MimeType Vnd_oasis_opendocument_image { get; } = new MimeType("application", "vnd.oasis.opendocument.image");
            public static MimeType Vnd_oasis_opendocument_image_template { get; } = new MimeType("application", "vnd.oasis.opendocument.image-template");
            public static MimeType Vnd_oasis_opendocument_presentation { get; } = new MimeType("application", "vnd.oasis.opendocument.presentation");
            public static MimeType Vnd_oasis_opendocument_presentation_template { get; } = new MimeType("application", "vnd.oasis.opendocument.presentation-template");
            public static MimeType Vnd_oasis_opendocument_spreadsheet { get; } = new MimeType("application", "vnd.oasis.opendocument.spreadsheet");
            public static MimeType Vnd_oasis_opendocument_spreadsheet_template { get; } = new MimeType("application", "vnd.oasis.opendocument.spreadsheet-template");
            public static MimeType Vnd_oasis_opendocument_text { get; } = new MimeType("application", "vnd.oasis.opendocument.text");
            public static MimeType Vnd_oasis_opendocument_text_master { get; } = new MimeType("application", "vnd.oasis.opendocument.text-master");
            public static MimeType Vnd_oasis_opendocument_text_template { get; } = new MimeType("application", "vnd.oasis.opendocument.text-template");
            public static MimeType Vnd_oasis_opendocument_text_web { get; } = new MimeType("application", "vnd.oasis.opendocument.text-web");
            public static MimeType Vnd_olpc_sugar { get; } = new MimeType("application", "vnd.olpc-sugar");
            public static MimeType Vnd_oma_dd2_xml { get; } = new MimeType("application", "vnd.oma.dd2+xml");
            public static MimeType Vnd_openofficeorg_extension { get; } = new MimeType("application", "vnd.openofficeorg.extension");
            public static MimeType Vnd_openxmlformats_officedocument_presentationml_presentation { get; } = new MimeType("application", "vnd.openxmlformats-officedocument.presentationml.presentation");
            public static MimeType Vnd_openxmlformats_officedocument_presentationml_slide { get; } = new MimeType("application", "vnd.openxmlformats-officedocument.presentationml.slide");
            public static MimeType Vnd_openxmlformats_officedocument_presentationml_slideshow { get; } = new MimeType("application", "vnd.openxmlformats-officedocument.presentationml.slideshow");
            public static MimeType Vnd_openxmlformats_officedocument_presentationml_template { get; } = new MimeType("application", "vnd.openxmlformats-officedocument.presentationml.template");
            public static MimeType Vnd_openxmlformats_officedocument_spreadsheetml_sheet { get; } = new MimeType("application", "vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            public static MimeType Vnd_openxmlformats_officedocument_spreadsheetml_template { get; } = new MimeType("application", "vnd.openxmlformats-officedocument.spreadsheetml.template");
            public static MimeType Vnd_openxmlformats_officedocument_wordprocessingml_document { get; } = new MimeType("application", "vnd.openxmlformats-officedocument.wordprocessingml.document");
            public static MimeType Vnd_openxmlformats_officedocument_wordprocessingml_template { get; } = new MimeType("application", "vnd.openxmlformats-officedocument.wordprocessingml.template");
            public static MimeType Vnd_osgeo_mapguide_package { get; } = new MimeType("application", "vnd.osgeo.mapguide.package");
            public static MimeType Vnd_osgi_dp { get; } = new MimeType("application", "vnd.osgi.dp");
            public static MimeType Vnd_osgi_subsystem { get; } = new MimeType("application", "vnd.osgi.subsystem");
            public static MimeType Vnd_palm { get; } = new MimeType("application", "vnd.palm");
            public static MimeType Vnd_pawaafile { get; } = new MimeType("application", "vnd.pawaafile");
            public static MimeType Vnd_pg_format { get; } = new MimeType("application", "vnd.pg.format");
            public static MimeType Vnd_pg_osasli { get; } = new MimeType("application", "vnd.pg.osasli");
            public static MimeType Vnd_picsel { get; } = new MimeType("application", "vnd.picsel");
            public static MimeType Vnd_pmi_widget { get; } = new MimeType("application", "vnd.pmi.widget");
            public static MimeType Vnd_pocketlearn { get; } = new MimeType("application", "vnd.pocketlearn");
            public static MimeType Vnd_powerbuilder6 { get; } = new MimeType("application", "vnd.powerbuilder6");
            public static MimeType Vnd_previewsystems_box { get; } = new MimeType("application", "vnd.previewsystems.box");
            public static MimeType Vnd_proteus_magazine { get; } = new MimeType("application", "vnd.proteus.magazine");
            public static MimeType Vnd_publishare_delta_tree { get; } = new MimeType("application", "vnd.publishare-delta-tree");
            public static MimeType Vnd_pvi_ptid1 { get; } = new MimeType("application", "vnd.pvi.ptid1");
            public static MimeType Vnd_quark_quarkxpress { get; } = new MimeType("application", "vnd.quark.quarkxpress");
            public static MimeType Vnd_realvnc_bed { get; } = new MimeType("application", "vnd.realvnc.bed");
            public static MimeType Vnd_recordare_musicxml { get; } = new MimeType("application", "vnd.recordare.musicxml");
            public static MimeType Vnd_recordare_musicxml_xml { get; } = new MimeType("application", "vnd.recordare.musicxml+xml");
            public static MimeType Vnd_rig_cryptonote { get; } = new MimeType("application", "vnd.rig.cryptonote");
            public static MimeType Vnd_rim_cod { get; } = new MimeType("application", "vnd.rim.cod");
            public static MimeType Vnd_rn_realmedia { get; } = new MimeType("application", "vnd.rn-realmedia");
            public static MimeType Vnd_rn_realmedia_vbr { get; } = new MimeType("application", "vnd.rn-realmedia-vbr");
            public static MimeType Vnd_rn_rn_music_package { get; } = new MimeType("application", "vnd.rn-rn_music_package");
            public static MimeType Vnd_route66_link66_xml { get; } = new MimeType("application", "vnd.route66.link66+xml");
            public static MimeType Vnd_sailingtracker_track { get; } = new MimeType("application", "vnd.sailingtracker.track");
            public static MimeType Vnd_seemail { get; } = new MimeType("application", "vnd.seemail");
            public static MimeType Vnd_sema { get; } = new MimeType("application", "vnd.sema");
            public static MimeType Vnd_semd { get; } = new MimeType("application", "vnd.semd");
            public static MimeType Vnd_semf { get; } = new MimeType("application", "vnd.semf");
            public static MimeType Vnd_shana_informed_formdata { get; } = new MimeType("application", "vnd.shana.informed.formdata");
            public static MimeType Vnd_shana_informed_formtemplate { get; } = new MimeType("application", "vnd.shana.informed.formtemplate");
            public static MimeType Vnd_shana_informed_interchange { get; } = new MimeType("application", "vnd.shana.informed.interchange");
            public static MimeType Vnd_shana_informed_package { get; } = new MimeType("application", "vnd.shana.informed.package");
            public static MimeType Vnd_simtech_mindmapper { get; } = new MimeType("application", "vnd.simtech-mindmapper");
            public static MimeType Vnd_smaf { get; } = new MimeType("application", "vnd.smaf");
            public static MimeType Vnd_smart_teacher { get; } = new MimeType("application", "vnd.smart.teacher");
            public static MimeType Vnd_solent_sdkm_xml { get; } = new MimeType("application", "vnd.solent.sdkm+xml");
            public static MimeType Vnd_spotfire_dxp { get; } = new MimeType("application", "vnd.spotfire.dxp");
            public static MimeType Vnd_spotfire_sfs { get; } = new MimeType("application", "vnd.spotfire.sfs");
            public static MimeType Vnd_stardivision_calc { get; } = new MimeType("application", "vnd.stardivision.calc");
            public static MimeType Vnd_stardivision_draw { get; } = new MimeType("application", "vnd.stardivision.draw");
            public static MimeType Vnd_stardivision_impress { get; } = new MimeType("application", "vnd.stardivision.impress");
            public static MimeType Vnd_stardivision_math { get; } = new MimeType("application", "vnd.stardivision.math");
            public static MimeType Vnd_stardivision_writer { get; } = new MimeType("application", "vnd.stardivision.writer");
            public static MimeType Vnd_stardivision_writer_global { get; } = new MimeType("application", "vnd.stardivision.writer-global");
            public static MimeType Vnd_stepmania_package { get; } = new MimeType("application", "vnd.stepmania.package");
            public static MimeType Vnd_stepmania_stepchart { get; } = new MimeType("application", "vnd.stepmania.stepchart");
            public static MimeType Vnd_sun_xml_calc { get; } = new MimeType("application", "vnd.sun.xml.calc");
            public static MimeType Vnd_sun_xml_calc_template { get; } = new MimeType("application", "vnd.sun.xml.calc.template");
            public static MimeType Vnd_sun_xml_draw { get; } = new MimeType("application", "vnd.sun.xml.draw");
            public static MimeType Vnd_sun_xml_draw_template { get; } = new MimeType("application", "vnd.sun.xml.draw.template");
            public static MimeType Vnd_sun_xml_impress { get; } = new MimeType("application", "vnd.sun.xml.impress");
            public static MimeType Vnd_sun_xml_impress_template { get; } = new MimeType("application", "vnd.sun.xml.impress.template");
            public static MimeType Vnd_sun_xml_math { get; } = new MimeType("application", "vnd.sun.xml.math");
            public static MimeType Vnd_sun_xml_writer { get; } = new MimeType("application", "vnd.sun.xml.writer");
            public static MimeType Vnd_sun_xml_writer_global { get; } = new MimeType("application", "vnd.sun.xml.writer.global");
            public static MimeType Vnd_sun_xml_writer_template { get; } = new MimeType("application", "vnd.sun.xml.writer.template");
            public static MimeType Vnd_sus_calendar { get; } = new MimeType("application", "vnd.sus-calendar");
            public static MimeType Vnd_svd { get; } = new MimeType("application", "vnd.svd");
            public static MimeType Vnd_symbian_install { get; } = new MimeType("application", "vnd.symbian.install");
            public static MimeType Vnd_syncml_dm_wbxml { get; } = new MimeType("application", "vnd.syncml.dm+wbxml");
            public static MimeType Vnd_syncml_dm_xml { get; } = new MimeType("application", "vnd.syncml.dm+xml");
            public static MimeType Vnd_syncml_xml { get; } = new MimeType("application", "vnd.syncml+xml");
            public static MimeType Vnd_tao_intent_module_archive { get; } = new MimeType("application", "vnd.tao.intent-module-archive");
            public static MimeType Vnd_tcpdump_pcap { get; } = new MimeType("application", "vnd.tcpdump.pcap");
            public static MimeType Vnd_tmobile_livetv { get; } = new MimeType("application", "vnd.tmobile-livetv");
            public static MimeType Vnd_trid_tpt { get; } = new MimeType("application", "vnd.trid.tpt");
            public static MimeType Vnd_triscape_mxs { get; } = new MimeType("application", "vnd.triscape.mxs");
            public static MimeType Vnd_trueapp { get; } = new MimeType("application", "vnd.trueapp");
            public static MimeType Vnd_ufdl { get; } = new MimeType("application", "vnd.ufdl");
            public static MimeType Vnd_uiq_theme { get; } = new MimeType("application", "vnd.uiq.theme");
            public static MimeType Vnd_umajin { get; } = new MimeType("application", "vnd.umajin");
            public static MimeType Vnd_unity { get; } = new MimeType("application", "vnd.unity");
            public static MimeType Vnd_uoml_xml { get; } = new MimeType("application", "vnd.uoml+xml");
            public static MimeType Vnd_vcx { get; } = new MimeType("application", "vnd.vcx");
            public static MimeType Vnd_visio { get; } = new MimeType("application", "vnd.visio");
            public static MimeType Vnd_visionary { get; } = new MimeType("application", "vnd.visionary");
            public static MimeType Vnd_vsf { get; } = new MimeType("application", "vnd.vsf");
            public static MimeType Vnd_wap_wbxml { get; } = new MimeType("application", "vnd.wap.wbxml");
            public static MimeType Vnd_wap_wmlc { get; } = new MimeType("application", "vnd.wap.wmlc");
            public static MimeType Vnd_wap_wmlscriptc { get; } = new MimeType("application", "vnd.wap.wmlscriptc");
            public static MimeType Vnd_webturbo { get; } = new MimeType("application", "vnd.webturbo");
            public static MimeType Vnd_wolfram_player { get; } = new MimeType("application", "vnd.wolfram.player");
            public static MimeType Vnd_wordperfect { get; } = new MimeType("application", "vnd.wordperfect");
            public static MimeType Vnd_wqd { get; } = new MimeType("application", "vnd.wqd");
            public static MimeType Vnd_wt_stf { get; } = new MimeType("application", "vnd.wt.stf");
            public static MimeType Vnd_xara { get; } = new MimeType("application", "vnd.xara");
            public static MimeType Vnd_xfdl { get; } = new MimeType("application", "vnd.xfdl");
            public static MimeType Vnd_yamaha_hv_dic { get; } = new MimeType("application", "vnd.yamaha.hv-dic");
            public static MimeType Vnd_yamaha_hv_script { get; } = new MimeType("application", "vnd.yamaha.hv-script");
            public static MimeType Vnd_yamaha_hv_voice { get; } = new MimeType("application", "vnd.yamaha.hv-voice");
            public static MimeType Vnd_yamaha_openscoreformat { get; } = new MimeType("application", "vnd.yamaha.openscoreformat");
            public static MimeType Vnd_yamaha_openscoreformat_osfpvg_xml { get; } = new MimeType("application", "vnd.yamaha.openscoreformat.osfpvg+xml");
            public static MimeType Vnd_yamaha_smaf_audio { get; } = new MimeType("application", "vnd.yamaha.smaf-audio");
            public static MimeType Vnd_yamaha_smaf_phrase { get; } = new MimeType("application", "vnd.yamaha.smaf-phrase");
            public static MimeType Vnd_yellowriver_custom_menu { get; } = new MimeType("application", "vnd.yellowriver-custom-menu");
            public static MimeType Vnd_zul { get; } = new MimeType("application", "vnd.zul");
            public static MimeType Vnd_zzazz_deck_xml { get; } = new MimeType("application", "vnd.zzazz.deck+xml");
            public static MimeType Voicexml_xml { get; } = new MimeType("application", "voicexml+xml");
            public static MimeType Vsix { get; } = new MimeType("application", "vsix");
            public static MimeType Wasm { get; } = new MimeType("application", "wasm");
            public static MimeType Widget { get; } = new MimeType("application", "widget");
            public static MimeType Windows_library_xml { get; } = new MimeType("application", "windows-library+xml");
            public static MimeType Windows_search_connector_xml { get; } = new MimeType("application", "windows-search-connector+xml");
            public static MimeType Winhlp { get; } = new MimeType("application", "winhlp");
            public static MimeType Wlmoviemaker { get; } = new MimeType("application", "wlmoviemaker");
            public static MimeType Wsdl_xml { get; } = new MimeType("application", "wsdl+xml");
            public static MimeType Wspolicy_xml { get; } = new MimeType("application", "wspolicy+xml");
            public static MimeType X_7z_compressed { get; } = new MimeType("application", "x-7z-compressed");
            public static MimeType X_abiword { get; } = new MimeType("application", "x-abiword");
            public static MimeType X_ace_compressed { get; } = new MimeType("application", "x-ace-compressed");
            public static MimeType Xaml_xml { get; } = new MimeType("application", "xaml+xml");
            public static MimeType X_apple_diskimage { get; } = new MimeType("application", "x-apple-diskimage");
            public static MimeType X_authorware_bin { get; } = new MimeType("application", "x-authorware-bin");
            public static MimeType X_authorware_map { get; } = new MimeType("application", "x-authorware-map");
            public static MimeType X_authorware_seg { get; } = new MimeType("application", "x-authorware-seg");
            public static MimeType X_bcpio { get; } = new MimeType("application", "x-bcpio");
            public static MimeType X_bittorrent { get; } = new MimeType("application", "x-bittorrent");
            public static MimeType X_blorb { get; } = new MimeType("application", "x-blorb");
            public static MimeType X_bridge_url { get; } = new MimeType("application", "x-bridge-url");
            public static MimeType X_bzip { get; } = new MimeType("application", "x-bzip");
            public static MimeType X_bzip2 { get; } = new MimeType("application", "x-bzip2");
            public static MimeType Xcap_diff_xml { get; } = new MimeType("application", "xcap-diff+xml");
            public static MimeType X_cbr { get; } = new MimeType("application", "x-cbr");
            public static MimeType X_cdf { get; } = new MimeType("application", "x-cdf");
            public static MimeType X_cdlink { get; } = new MimeType("application", "x-cdlink");
            public static MimeType X_cfs_compressed { get; } = new MimeType("application", "x-cfs-compressed");
            public static MimeType X_chat { get; } = new MimeType("application", "x-chat");
            public static MimeType X_chess_pgn { get; } = new MimeType("application", "x-chess-pgn");
            public static MimeType X_compress { get; } = new MimeType("application", "x-compress");
            public static MimeType X_compressed { get; } = new MimeType("application", "x-compressed");
            public static MimeType X_conference { get; } = new MimeType("application", "x-conference");
            public static MimeType X_cpio { get; } = new MimeType("application", "x-cpio");
            public static MimeType X_csh { get; } = new MimeType("application", "x-csh");
            public static MimeType X_debian_package { get; } = new MimeType("application", "x-debian-package");
            public static MimeType X_dgc_compressed { get; } = new MimeType("application", "x-dgc-compressed");
            public static MimeType X_director { get; } = new MimeType("application", "x-director");
            public static MimeType X_doom { get; } = new MimeType("application", "x-doom");
            public static MimeType X_dtbncx_xml { get; } = new MimeType("application", "x-dtbncx+xml");
            public static MimeType X_dtbook_xml { get; } = new MimeType("application", "x-dtbook+xml");
            public static MimeType X_dtbresource_xml { get; } = new MimeType("application", "x-dtbresource+xml");
            public static MimeType X_dvi { get; } = new MimeType("application", "x-dvi");
            public static MimeType X_dxf { get; } = new MimeType("application", "x-dxf");
            public static MimeType Xenc_xml { get; } = new MimeType("application", "xenc+xml");
            public static MimeType X_envoy { get; } = new MimeType("application", "x-envoy");
            public static MimeType X_eva { get; } = new MimeType("application", "x-eva");
            public static MimeType X_font_bdf { get; } = new MimeType("application", "x-font-bdf");
            public static MimeType X_font_ghostscript { get; } = new MimeType("application", "x-font-ghostscript");
            public static MimeType X_font_linux_psf { get; } = new MimeType("application", "x-font-linux-psf");
            public static MimeType X_font_otf { get; } = new MimeType("application", "x-font-otf");
            public static MimeType X_font_pcf { get; } = new MimeType("application", "x-font-pcf");
            public static MimeType X_font_snf { get; } = new MimeType("application", "x-font-snf");
            public static MimeType X_font_ttf { get; } = new MimeType("application", "x-font-ttf");
            public static MimeType X_font_type1 { get; } = new MimeType("application", "x-font-type1");
            public static MimeType X_freearc { get; } = new MimeType("application", "x-freearc");
            public static MimeType X_futuresplash { get; } = new MimeType("application", "x-futuresplash");
            public static MimeType X_gca_compressed { get; } = new MimeType("application", "x-gca-compressed");
            public static MimeType X_glulx { get; } = new MimeType("application", "x-glulx");
            public static MimeType X_gnumeric { get; } = new MimeType("application", "x-gnumeric");
            public static MimeType X_gramps_xml { get; } = new MimeType("application", "x-gramps-xml");
            public static MimeType X_gtar { get; } = new MimeType("application", "x-gtar");
            public static MimeType X_gzip { get; } = new MimeType("application", "x-gzip");
            public static MimeType X_hdf { get; } = new MimeType("application", "x-hdf");
            public static MimeType Xhtml_xml { get; } = new MimeType("application", "xhtml+xml");
            public static MimeType X_install_instructions { get; } = new MimeType("application", "x-install-instructions");
            public static MimeType X_internet_signup { get; } = new MimeType("application", "x-internet-signup");
            public static MimeType X_iphone { get; } = new MimeType("application", "x-iphone");
            public static MimeType X_iso9660_image { get; } = new MimeType("application", "x-iso9660-image");
            public static MimeType X_itunes_ipa { get; } = new MimeType("application", "x-itunes-ipa");
            public static MimeType X_itunes_ipg { get; } = new MimeType("application", "x-itunes-ipg");
            public static MimeType X_itunes_ipsw { get; } = new MimeType("application", "x-itunes-ipsw");
            public static MimeType X_itunes_ite { get; } = new MimeType("application", "x-itunes-ite");
            public static MimeType X_itunes_itlp { get; } = new MimeType("application", "x-itunes-itlp");
            public static MimeType X_itunes_itms { get; } = new MimeType("application", "x-itunes-itms");
            public static MimeType X_itunes_itpc { get; } = new MimeType("application", "x-itunes-itpc");
            public static MimeType X_java_applet { get; } = new MimeType("application", "x-java-applet");
            public static MimeType X_java_jnlp_file { get; } = new MimeType("application", "x-java-jnlp-file");
            public static MimeType X_koan { get; } = new MimeType("application", "x-koan");
            public static MimeType X_latex { get; } = new MimeType("application", "x-latex");
            public static MimeType X_lzh_compressed { get; } = new MimeType("application", "x-lzh-compressed");
            public static MimeType X_mie { get; } = new MimeType("application", "x-mie");
            public static MimeType X_miva_compiled { get; } = new MimeType("application", "x-miva-compiled");
            public static MimeType Xml { get; } = new MimeType("application", "xml");
            public static MimeType Xml_dtd { get; } = new MimeType("application", "xml-dtd");
            public static MimeType X_mmxp { get; } = new MimeType("application", "x-mmxp");
            public static MimeType X_mobipocket_ebook { get; } = new MimeType("application", "x-mobipocket-ebook");
            public static MimeType X_msaccess { get; } = new MimeType("application", "x-msaccess");
            public static MimeType X_ms_application { get; } = new MimeType("application", "x-ms-application");
            public static MimeType X_msbinder { get; } = new MimeType("application", "x-msbinder");
            public static MimeType X_mscardfile { get; } = new MimeType("application", "x-mscardfile");
            public static MimeType X_msclip { get; } = new MimeType("application", "x-msclip");
            public static MimeType X_msdownload { get; } = new MimeType("application", "x-msdownload");
            public static MimeType X_ms_license { get; } = new MimeType("application", "x-ms-license");
            public static MimeType X_ms_manifest { get; } = new MimeType("application", "x-ms-manifest");
            public static MimeType X_msmediaview { get; } = new MimeType("application", "x-msmediaview");
            public static MimeType X_msmetafile { get; } = new MimeType("application", "x-msmetafile");
            public static MimeType X_msmoney { get; } = new MimeType("application", "x-msmoney");
            public static MimeType X_mspublisher { get; } = new MimeType("application", "x-mspublisher");
            public static MimeType X_ms_reader { get; } = new MimeType("application", "x-ms-reader");
            public static MimeType X_msschedule { get; } = new MimeType("application", "x-msschedule");
            public static MimeType X_ms_shortcut { get; } = new MimeType("application", "x-ms-shortcut");
            public static MimeType X_msterminal { get; } = new MimeType("application", "x-msterminal");
            public static MimeType X_ms_vsto { get; } = new MimeType("application", "x-ms-vsto");
            public static MimeType X_ms_wmd { get; } = new MimeType("application", "x-ms-wmd");
            public static MimeType X_ms_wmz { get; } = new MimeType("application", "x-ms-wmz");
            public static MimeType X_mswrite { get; } = new MimeType("application", "x-mswrite");
            public static MimeType X_ms_xbap { get; } = new MimeType("application", "x-ms-xbap");
            public static MimeType X_netcdf { get; } = new MimeType("application", "x-netcdf");
            public static MimeType X_nzb { get; } = new MimeType("application", "x-nzb");
            public static MimeType X_oleobject { get; } = new MimeType("application", "x-oleobject");
            public static MimeType Xop_xml { get; } = new MimeType("application", "xop+xml");
            public static MimeType X_perfmon { get; } = new MimeType("application", "x-perfmon");
            public static MimeType X_pkcs12 { get; } = new MimeType("application", "x-pkcs12");
            public static MimeType X_pkcs7_certificates { get; } = new MimeType("application", "x-pkcs7-certificates");
            public static MimeType X_pkcs7_certreqresp { get; } = new MimeType("application", "x-pkcs7-certreqresp");
            public static MimeType X_podcast { get; } = new MimeType("application", "x-podcast");
            public static MimeType Xproc_xml { get; } = new MimeType("application", "xproc+xml");
            public static MimeType X_quicktimeplayer { get; } = new MimeType("application", "x-quicktimeplayer");
            public static MimeType X_rar_compressed { get; } = new MimeType("application", "x-rar-compressed");
            public static MimeType X_research_info_systems { get; } = new MimeType("application", "x-research-info-systems");
            public static MimeType X_safari_safariextz { get; } = new MimeType("application", "x-safari-safariextz");
            public static MimeType X_safari_webarchive { get; } = new MimeType("application", "x-safari-webarchive");
            public static MimeType X_sgimb { get; } = new MimeType("application", "x-sgimb");
            public static MimeType X_sh { get; } = new MimeType("application", "x-sh");
            public static MimeType X_shar { get; } = new MimeType("application", "x-shar");
            public static MimeType X_shockwave_flash { get; } = new MimeType("application", "x-shockwave-flash");
            public static MimeType X_silverlight_app { get; } = new MimeType("application", "x-silverlight-app");
            public static MimeType Xslt_xml { get; } = new MimeType("application", "xslt+xml");
            public static MimeType X_smaf { get; } = new MimeType("application", "x-smaf");
            public static MimeType Xspf_xml { get; } = new MimeType("application", "xspf+xml");
            public static MimeType X_sql { get; } = new MimeType("application", "x-sql");
            public static MimeType X_stuffit { get; } = new MimeType("application", "x-stuffit");
            public static MimeType X_stuffitx { get; } = new MimeType("application", "x-stuffitx");
            public static MimeType X_subrip { get; } = new MimeType("application", "x-subrip");
            public static MimeType X_sv4cpio { get; } = new MimeType("application", "x-sv4cpio");
            public static MimeType X_sv4crc { get; } = new MimeType("application", "x-sv4crc");
            public static MimeType X_t3vm_image { get; } = new MimeType("application", "x-t3vm-image");
            public static MimeType X_tads { get; } = new MimeType("application", "x-tads");
            public static MimeType X_tar { get; } = new MimeType("application", "x-tar");
            public static MimeType X_tcl { get; } = new MimeType("application", "x-tcl");
            public static MimeType X_tex { get; } = new MimeType("application", "x-tex");
            public static MimeType X_texinfo { get; } = new MimeType("application", "x-texinfo");
            public static MimeType X_tex_tfm { get; } = new MimeType("application", "x-tex-tfm");
            public static MimeType X_tgif { get; } = new MimeType("application", "x-tgif");
            public static MimeType X_troff { get; } = new MimeType("application", "x-troff");
            public static MimeType X_troff_man { get; } = new MimeType("application", "x-troff-man");
            public static MimeType X_troff_me { get; } = new MimeType("application", "x-troff-me");
            public static MimeType X_troff_ms { get; } = new MimeType("application", "x-troff-ms");
            public static MimeType X_ustar { get; } = new MimeType("application", "x-ustar");
            public static MimeType Xv_xml { get; } = new MimeType("application", "xv+xml");
            public static MimeType X_wais_source { get; } = new MimeType("application", "x-wais-source");
            public static MimeType X_wlpg3_detect { get; } = new MimeType("application", "x-wlpg3-detect");
            public static MimeType X_wlpg_detect { get; } = new MimeType("application", "x-wlpg-detect");
            public static MimeType X_x509_ca_cert { get; } = new MimeType("application", "x-x509-ca-cert");
            public static MimeType X_xfig { get; } = new MimeType("application", "x-xfig");
            public static MimeType X_xliff_xml { get; } = new MimeType("application", "x-xliff+xml");
            public static MimeType X_xpinstall { get; } = new MimeType("application", "x-xpinstall");
            public static MimeType X_xz { get; } = new MimeType("application", "x-xz");
            public static MimeType X_zip_compressed { get; } = new MimeType("application", "x-zip-compressed");
            public static MimeType X_zmachine { get; } = new MimeType("application", "x-zmachine");
            public static MimeType Yang { get; } = new MimeType("application", "yang");
            public static MimeType Yin_xml { get; } = new MimeType("application", "yin+xml");
            public static MimeType Zip { get; } = new MimeType("application", "zip");


            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Application));
            }
        }


        public static class Audio
        {
            public const string Type = "audio";

            public static MimeType Aac { get; } = new MimeType("audio", "aac");
            public static MimeType Ac3 { get; } = new MimeType("audio", "ac3");
            public static MimeType Adpcm { get; } = new MimeType("audio", "adpcm");
            public static MimeType Aiff { get; } = new MimeType("audio", "aiff");
            public static MimeType Annodex { get; } = new MimeType("audio", "annodex");
            public static MimeType Audible { get; } = new MimeType("audio", "audible");
            public static MimeType Basic { get; } = new MimeType("audio", "basic");
            public static MimeType Flac { get; } = new MimeType("audio", "flac");
            public static MimeType M4a { get; } = new MimeType("audio", "m4a");
            public static MimeType M4b { get; } = new MimeType("audio", "m4b");
            public static MimeType M4p { get; } = new MimeType("audio", "m4p");
            public static MimeType Mid { get; } = new MimeType("audio", "mid");
            public static MimeType Midi { get; } = new MimeType("audio", "midi");
            public static MimeType Mp4 { get; } = new MimeType("audio", "mp4");
            public static MimeType Mpeg { get; } = new MimeType("audio", "mpeg");
            public static MimeType Ogg { get; } = new MimeType("audio", "ogg");
            public static MimeType S3m { get; } = new MimeType("audio", "s3m");
            public static MimeType Scpls { get; } = new MimeType("audio", "scpls");
            public static MimeType Silk { get; } = new MimeType("audio", "silk");
            public static MimeType Vnd_audible_aax { get; } = new MimeType("audio", "vnd.audible.aax");
            public static MimeType Vnd_dece_audio { get; } = new MimeType("audio", "vnd.dece.audio");
            public static MimeType Vnd_digital_winds { get; } = new MimeType("audio", "vnd.digital-winds");
            public static MimeType Vnd_dlna_adts { get; } = new MimeType("audio", "vnd.dlna.adts");
            public static MimeType Vnd_dra { get; } = new MimeType("audio", "vnd.dra");
            public static MimeType Vnd_dts { get; } = new MimeType("audio", "vnd.dts");
            public static MimeType Vnd_dts_hd { get; } = new MimeType("audio", "vnd.dts.hd");
            public static MimeType Vnd_lucent_voice { get; } = new MimeType("audio", "vnd.lucent.voice");
            public static MimeType Vnd_ms_playready_media_pya { get; } = new MimeType("audio", "vnd.ms-playready.media.pya");
            public static MimeType Vnd_nuera_ecelp4800 { get; } = new MimeType("audio", "vnd.nuera.ecelp4800");
            public static MimeType Vnd_nuera_ecelp7470 { get; } = new MimeType("audio", "vnd.nuera.ecelp7470");
            public static MimeType Vnd_nuera_ecelp9600 { get; } = new MimeType("audio", "vnd.nuera.ecelp9600");
            public static MimeType Vnd_rip { get; } = new MimeType("audio", "vnd.rip");
            public static MimeType Wav { get; } = new MimeType("audio", "wav");
            public static MimeType Webm { get; } = new MimeType("audio", "webm");
            public static MimeType X_aac { get; } = new MimeType("audio", "x-aac");
            public static MimeType X_aiff { get; } = new MimeType("audio", "x-aiff");
            public static MimeType X_caf { get; } = new MimeType("audio", "x-caf");
            public static MimeType X_flac { get; } = new MimeType("audio", "x-flac");
            public static MimeType X_gsm { get; } = new MimeType("audio", "x-gsm");
            public static MimeType Xm { get; } = new MimeType("audio", "xm");
            public static MimeType X_m4a { get; } = new MimeType("audio", "x-m4a");
            public static MimeType X_m4r { get; } = new MimeType("audio", "x-m4r");
            public static MimeType X_matroska { get; } = new MimeType("audio", "x-matroska");
            public static MimeType X_mpegurl { get; } = new MimeType("audio", "x-mpegurl");
            public static MimeType X_ms_wax { get; } = new MimeType("audio", "x-ms-wax");
            public static MimeType X_ms_wma { get; } = new MimeType("audio", "x-ms-wma");
            public static MimeType X_pn_realaudio { get; } = new MimeType("audio", "x-pn-realaudio");
            public static MimeType X_pn_realaudio_plugin { get; } = new MimeType("audio", "x-pn-realaudio-plugin");
            public static MimeType X_sd2 { get; } = new MimeType("audio", "x-sd2");
            public static MimeType X_smd { get; } = new MimeType("audio", "x-smd");
            public static MimeType X_wav { get; } = new MimeType("audio", "x-wav");


            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Application));
            }
        }


        public static class Chemical
        {
            public const string Type = "chemical";

            public static MimeType X_cdx { get; } = new MimeType("chemical", "x-cdx");
            public static MimeType X_cif { get; } = new MimeType("chemical", "x-cif");
            public static MimeType X_cmdf { get; } = new MimeType("chemical", "x-cmdf");
            public static MimeType X_cml { get; } = new MimeType("chemical", "x-cml");
            public static MimeType X_csml { get; } = new MimeType("chemical", "x-csml");
            public static MimeType X_xyz { get; } = new MimeType("chemical", "x-xyz");


            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Application));
            }
        }


        public static class Drawing
        {
            public const string Type = "drawing";

            public static MimeType X_dwf { get; } = new MimeType("drawing", "x-dwf");


            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Application));
            }
        }


        public static class Image
        {
            public const string Type = "image";

            public static MimeType Bmp { get; } = new MimeType("image", "bmp");
            public static MimeType Cgm { get; } = new MimeType("image", "cgm");
            public static MimeType Cis_cod { get; } = new MimeType("image", "cis-cod");
            public static MimeType Emf { get; } = new MimeType("image", "emf");
            public static MimeType G3fax { get; } = new MimeType("image", "g3fax");
            public static MimeType Gif { get; } = new MimeType("image", "gif");
            public static MimeType Ief { get; } = new MimeType("image", "ief");
            public static MimeType Jpeg { get; } = new MimeType("image", "jpeg");
            public static MimeType Ktx { get; } = new MimeType("image", "ktx");
            public static MimeType Pict { get; } = new MimeType("image", "pict");
            public static MimeType Pjpeg { get; } = new MimeType("image", "pjpeg");
            public static MimeType Png { get; } = new MimeType("image", "png");
            public static MimeType Prs_btif { get; } = new MimeType("image", "prs.btif");
            public static MimeType Sgi { get; } = new MimeType("image", "sgi");
            public static MimeType Svg_xml { get; } = new MimeType("image", "svg+xml");
            public static MimeType Tiff { get; } = new MimeType("image", "tiff");
            public static MimeType Vnd_adobe_photoshop { get; } = new MimeType("image", "vnd.adobe.photoshop");
            public static MimeType Vnd_dece_graphic { get; } = new MimeType("image", "vnd.dece.graphic");
            public static MimeType Vnd_djvu { get; } = new MimeType("image", "vnd.djvu");
            public static MimeType Vnd_dwg { get; } = new MimeType("image", "vnd.dwg");
            public static MimeType Vnd_dxf { get; } = new MimeType("image", "vnd.dxf");
            public static MimeType Vnd_fastbidsheet { get; } = new MimeType("image", "vnd.fastbidsheet");
            public static MimeType Vnd_fpx { get; } = new MimeType("image", "vnd.fpx");
            public static MimeType Vnd_fst { get; } = new MimeType("image", "vnd.fst");
            public static MimeType Vnd_fujixerox_edmics_mmr { get; } = new MimeType("image", "vnd.fujixerox.edmics-mmr");
            public static MimeType Vnd_fujixerox_edmics_rlc { get; } = new MimeType("image", "vnd.fujixerox.edmics-rlc");
            public static MimeType Vnd_ms_modi { get; } = new MimeType("image", "vnd.ms-modi");
            public static MimeType Vnd_ms_photo { get; } = new MimeType("image", "vnd.ms-photo");
            public static MimeType Vnd_net_fpx { get; } = new MimeType("image", "vnd.net-fpx");
            public static MimeType Vnd_rn_realflash { get; } = new MimeType("image", "vnd.rn-realflash");
            public static MimeType Vnd_wap_wbmp { get; } = new MimeType("image", "vnd.wap.wbmp");
            public static MimeType Vnd_xiff { get; } = new MimeType("image", "vnd.xiff");
            public static MimeType Webp { get; } = new MimeType("image", "webp");
            public static MimeType X_3ds { get; } = new MimeType("image", "x-3ds");
            public static MimeType X_cmu_raster { get; } = new MimeType("image", "x-cmu-raster");
            public static MimeType X_cmx { get; } = new MimeType("image", "x-cmx");
            public static MimeType X_freehand { get; } = new MimeType("image", "x-freehand");
            public static MimeType X_icon { get; } = new MimeType("image", "x-icon");
            public static MimeType X_jg { get; } = new MimeType("image", "x-jg");
            public static MimeType X_macpaint { get; } = new MimeType("image", "x-macpaint");
            public static MimeType X_mrsid_image { get; } = new MimeType("image", "x-mrsid-image");
            public static MimeType X_pcx { get; } = new MimeType("image", "x-pcx");
            public static MimeType X_pict { get; } = new MimeType("image", "x-pict");
            public static MimeType X_png { get; } = new MimeType("image", "x-png");
            public static MimeType X_portable_anymap { get; } = new MimeType("image", "x-portable-anymap");
            public static MimeType X_portable_bitmap { get; } = new MimeType("image", "x-portable-bitmap");
            public static MimeType X_portable_graymap { get; } = new MimeType("image", "x-portable-graymap");
            public static MimeType X_portable_pixmap { get; } = new MimeType("image", "x-portable-pixmap");
            public static MimeType X_quicktime { get; } = new MimeType("image", "x-quicktime");
            public static MimeType X_rgb { get; } = new MimeType("image", "x-rgb");
            public static MimeType X_tga { get; } = new MimeType("image", "x-tga");
            public static MimeType X_xbitmap { get; } = new MimeType("image", "x-xbitmap");
            public static MimeType X_xpixmap { get; } = new MimeType("image", "x-xpixmap");
            public static MimeType X_xwindowdump { get; } = new MimeType("image", "x-xwindowdump");


            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Application));
            }
        }


        public static class Message
        {
            public const string Type = "message";

            public static MimeType Rfc822 { get; } = new MimeType("message", "rfc822");


            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Application));
            }
        }


        public static class Model
        {
            public const string Type = "model";

            public static MimeType Iges { get; } = new MimeType("model", "iges");
            public static MimeType Mesh { get; } = new MimeType("model", "mesh");
            public static MimeType Vnd_collada_xml { get; } = new MimeType("model", "vnd.collada+xml");
            public static MimeType Vnd_dwf { get; } = new MimeType("model", "vnd.dwf");
            public static MimeType Vnd_gdl { get; } = new MimeType("model", "vnd.gdl");
            public static MimeType Vnd_gtw { get; } = new MimeType("model", "vnd.gtw");
            public static MimeType Vnd_mts { get; } = new MimeType("model", "vnd.mts");
            public static MimeType Vnd_vtu { get; } = new MimeType("model", "vnd.vtu");
            public static MimeType Vrml { get; } = new MimeType("model", "vrml");
            public static MimeType X3d_binary { get; } = new MimeType("model", "x3d+binary");
            public static MimeType X3d_vrml { get; } = new MimeType("model", "x3d+vrml");
            public static MimeType X3d_xml { get; } = new MimeType("model", "x3d+xml");


            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Application));
            }
        }


        public static class Text
        {
            public const string Type = "text";

            public static MimeType Cache_manifest { get; } = new MimeType("text", "cache-manifest");
            public static MimeType Calendar { get; } = new MimeType("text", "calendar");
            public static MimeType Css { get; } = new MimeType("text", "css");
            public static MimeType Csv { get; } = new MimeType("text", "csv");
            public static MimeType Dlm { get; } = new MimeType("text", "dlm");
            public static MimeType H323 { get; } = new MimeType("text", "h323");
            public static MimeType Html { get; } = new MimeType("text", "html");
            public static MimeType Iuls { get; } = new MimeType("text", "iuls");
            public static MimeType Jscript { get; } = new MimeType("text", "jscript");
            public static MimeType N3 { get; } = new MimeType("text", "n3");
            public static MimeType Plain { get; } = new MimeType("text", "plain");
            public static MimeType Prs_lines_tag { get; } = new MimeType("text", "prs.lines.tag");
            public static MimeType Richtext { get; } = new MimeType("text", "richtext");
            public static MimeType Scriptlet { get; } = new MimeType("text", "scriptlet");
            public static MimeType Sgml { get; } = new MimeType("text", "sgml");
            public static MimeType Tab_separated_values { get; } = new MimeType("text", "tab-separated-values");
            public static MimeType Troff { get; } = new MimeType("text", "troff");
            public static MimeType Turtle { get; } = new MimeType("text", "turtle");
            public static MimeType Uri_list { get; } = new MimeType("text", "uri-list");
            public static MimeType Vbscript { get; } = new MimeType("text", "vbscript");
            public static MimeType Vcard { get; } = new MimeType("text", "vcard");
            public static MimeType Vnd_curl { get; } = new MimeType("text", "vnd.curl");
            public static MimeType Vnd_curl_dcurl { get; } = new MimeType("text", "vnd.curl.dcurl");
            public static MimeType Vnd_curl_mcurl { get; } = new MimeType("text", "vnd.curl.mcurl");
            public static MimeType Vnd_curl_scurl { get; } = new MimeType("text", "vnd.curl.scurl");
            public static MimeType Vnd_dvb_subtitle { get; } = new MimeType("text", "vnd.dvb.subtitle");
            public static MimeType Vnd_fly { get; } = new MimeType("text", "vnd.fly");
            public static MimeType Vnd_fmi_flexstor { get; } = new MimeType("text", "vnd.fmi.flexstor");
            public static MimeType Vnd_graphviz { get; } = new MimeType("text", "vnd.graphviz");
            public static MimeType Vnd_in3d_3dml { get; } = new MimeType("text", "vnd.in3d.3dml");
            public static MimeType Vnd_in3d_spot { get; } = new MimeType("text", "vnd.in3d.spot");
            public static MimeType Vnd_sun_j2me_app_descriptor { get; } = new MimeType("text", "vnd.sun.j2me.app-descriptor");
            public static MimeType Vnd_wap_wml { get; } = new MimeType("text", "vnd.wap.wml");
            public static MimeType Vnd_wap_wmlscript { get; } = new MimeType("text", "vnd.wap.wmlscript");
            public static MimeType Vtt { get; } = new MimeType("text", "vtt");
            public static MimeType Webviewhtml { get; } = new MimeType("text", "webviewhtml");
            public static MimeType X_asm { get; } = new MimeType("text", "x-asm");
            public static MimeType X_c { get; } = new MimeType("text", "x-c");
            public static MimeType X_component { get; } = new MimeType("text", "x-component");
            public static MimeType X_fortran { get; } = new MimeType("text", "x-fortran");
            public static MimeType X_hdml { get; } = new MimeType("text", "x-hdml");
            public static MimeType X_html_insertion { get; } = new MimeType("text", "x-html-insertion");
            public static MimeType X_java_source { get; } = new MimeType("text", "x-java-source");
            public static MimeType Xml { get; } = new MimeType("text", "xml");
            public static MimeType X_ms_contact { get; } = new MimeType("text", "x-ms-contact");
            public static MimeType X_ms_group { get; } = new MimeType("text", "x-ms-group");
            public static MimeType X_ms_iqy { get; } = new MimeType("text", "x-ms-iqy");
            public static MimeType X_ms_rqy { get; } = new MimeType("text", "x-ms-rqy");
            public static MimeType X_nfo { get; } = new MimeType("text", "x-nfo");
            public static MimeType X_opml { get; } = new MimeType("text", "x-opml");
            public static MimeType X_pascal { get; } = new MimeType("text", "x-pascal");
            public static MimeType X_setext { get; } = new MimeType("text", "x-setext");
            public static MimeType X_sfv { get; } = new MimeType("text", "x-sfv");
            public static MimeType X_uuencode { get; } = new MimeType("text", "x-uuencode");
            public static MimeType X_vcalendar { get; } = new MimeType("text", "x-vcalendar");
            public static MimeType X_vcard { get; } = new MimeType("text", "x-vcard");


            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Application));
            }
        }


        public static class Video
        {
            public const string Type = "video";

            public static MimeType _gpp { get; } = new MimeType("video", "3gpp");
            public static MimeType _gpp2 { get; } = new MimeType("video", "3gpp2");
            public static MimeType Annodex { get; } = new MimeType("video", "annodex");
            public static MimeType Divx { get; } = new MimeType("video", "divx");
            public static MimeType H261 { get; } = new MimeType("video", "h261");
            public static MimeType H263 { get; } = new MimeType("video", "h263");
            public static MimeType H264 { get; } = new MimeType("video", "h264");
            public static MimeType Jpeg { get; } = new MimeType("video", "jpeg");
            public static MimeType Jpm { get; } = new MimeType("video", "jpm");
            public static MimeType Mj2 { get; } = new MimeType("video", "mj2");
            public static MimeType Mp4 { get; } = new MimeType("video", "mp4");
            public static MimeType Mpeg { get; } = new MimeType("video", "mpeg");
            public static MimeType Ogg { get; } = new MimeType("video", "ogg");
            public static MimeType Quicktime { get; } = new MimeType("video", "quicktime");
            public static MimeType Vnd_dece_hd { get; } = new MimeType("video", "vnd.dece.hd");
            public static MimeType Vnd_dece_mobile { get; } = new MimeType("video", "vnd.dece.mobile");
            public static MimeType Vnd_dece_pd { get; } = new MimeType("video", "vnd.dece.pd");
            public static MimeType Vnd_dece_sd { get; } = new MimeType("video", "vnd.dece.sd");
            public static MimeType Vnd_dece_video { get; } = new MimeType("video", "vnd.dece.video");
            public static MimeType Vnd_dlna_mpeg_tts { get; } = new MimeType("video", "vnd.dlna.mpeg-tts");
            public static MimeType Vnd_dvb_file { get; } = new MimeType("video", "vnd.dvb.file");
            public static MimeType Vnd_fvt { get; } = new MimeType("video", "vnd.fvt");
            public static MimeType Vnd_mpegurl { get; } = new MimeType("video", "vnd.mpegurl");
            public static MimeType Vnd_ms_playready_media_pyv { get; } = new MimeType("video", "vnd.ms-playready.media.pyv");
            public static MimeType Vnd_uvvu_mp4 { get; } = new MimeType("video", "vnd.uvvu.mp4");
            public static MimeType Vnd_vivo { get; } = new MimeType("video", "vnd.vivo");
            public static MimeType Webm { get; } = new MimeType("video", "webm");
            public static MimeType X_dv { get; } = new MimeType("video", "x-dv");
            public static MimeType X_f4v { get; } = new MimeType("video", "x-f4v");
            public static MimeType X_fli { get; } = new MimeType("video", "x-fli");
            public static MimeType X_flv { get; } = new MimeType("video", "x-flv");
            public static MimeType X_ivf { get; } = new MimeType("video", "x-ivf");
            public static MimeType X_la_asf { get; } = new MimeType("video", "x-la-asf");
            public static MimeType X_m4v { get; } = new MimeType("video", "x-m4v");
            public static MimeType X_matroska { get; } = new MimeType("video", "x-matroska");
            public static MimeType X_matroska_3d { get; } = new MimeType("video", "x-matroska-3d");
            public static MimeType X_mng { get; } = new MimeType("video", "x-mng");
            public static MimeType X_ms_asf { get; } = new MimeType("video", "x-ms-asf");
            public static MimeType X_msvideo { get; } = new MimeType("video", "x-msvideo");
            public static MimeType X_ms_vob { get; } = new MimeType("video", "x-ms-vob");
            public static MimeType X_ms_wm { get; } = new MimeType("video", "x-ms-wm");
            public static MimeType X_ms_wmp { get; } = new MimeType("video", "x-ms-wmp");
            public static MimeType X_ms_wmv { get; } = new MimeType("video", "x-ms-wmv");
            public static MimeType X_ms_wmx { get; } = new MimeType("video", "x-ms-wmx");
            public static MimeType X_ms_wvx { get; } = new MimeType("video", "x-ms-wvx");
            public static MimeType X_sgi_movie { get; } = new MimeType("video", "x-sgi-movie");
            public static MimeType X_smv { get; } = new MimeType("video", "x-smv");


            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Application));
            }
        }


        public static class X_conference
        {
            public const string Type = "x-conference";

            public static MimeType X_cooltalk { get; } = new MimeType("x-conference", "x-cooltalk");


            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Application));
            }
        }


        public static class X_world
        {
            public const string Type = "x-world";

            public static MimeType X_vrml { get; } = new MimeType("x-world", "x-vrml");


            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Application));
            }
        }


    }
}
