interface Societe {
    idsociete: number,
    idnomSociete: string,
    idsocieteParent: number,
    idlistePays: number,
    idlisteFormeJuridique: number,
    idutilisateur: number,
    idtypeNature: number,
    idstatut: boolean,
    idstatutClient: boolean,
    codeApe: string,
    leftCodeApe3: string,
    leftCodeApe2: string,
    codeApe2008: string,
    idgroupeSociete: number,
    groupe: string,
    nomSociete: string,
    adresse1: string,
    adresse2: string,
    adresse3: string,
    codePostal: string,
    leftCodePostal2: string,
    ville: string,
    telephoneSociete: string,
    faxSociete: string,
    emailSociete: string,
    siteInternet: string,
    activiteSociete: string,
    kompass: string,
    siret: string,
    dateFondation: Date,
    ca: string,
    idtypeCa: number,
    anneeCa: number,
    effectif: string,
    idtypeEffectif: number,
    anneeEffectif: number,
    capital: string,
    idtypeCapital: number,
    anneeCapital: number,
    oldIdsociete: number,
    idlisteBase: number,
    dateMajsociete: number,
    idsocieteProprietaire: number,
    listeRougeTelephoneSociete: boolean,
    dateMajmanuelleSociete: Date,
    dateCreationSociete: Date,
    idnomVille: string,
}
interface obj_Societe{
    description: string;
    errorCode: string;
    result: Societe;
}
interface obj_update_Societe{
    description: string;
    errorCode: string;
    result: string;
}