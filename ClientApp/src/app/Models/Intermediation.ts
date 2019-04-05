
interface Intermediation {
    idintermediation: number;
    idlisteService: number;
    idlisteSousService: number;
    dateIntermediation: Date;
    intermediation1: string;
    lieu: string;
    description: string;
    choixdeRdv: boolean;
    iddocument: number;
    idenquetePageWeb: number;
    idselectionIntermediation: number;
    idselectionListePlage: number;
    idselectionListeIndisponibilite: number;
    intituleTypeVendeur: string;
    idenqueteVendeur: number;
    idabonnementVendeur: number;
    idutilisateurVendeur: number;
    intituleTypeAcheteur: string;
    idenqueteAcheteur: number;
    idenqueteAcheteurBesoin: number;
    idabonnementAcheteur: number;
    idutilisateurAcheteur: number;
    idstatut: ByteString;
    siteWebIntermediation ?: string;
    intermediationParametres: string;
    ouvertureDateChoix: Date;
    ouvertureHeureChoix: string;
    fermetureTheoriqueDateChoix: Date;
    fermetureTheoriqueHeureChoix: string;
    fermetureDateChoix: Date;
    fermetureHeureChoix: string;
}
interface ObjectResult_Intermediation {
    description: string;
    errorCode: string;
    result: Intermediation;
}


