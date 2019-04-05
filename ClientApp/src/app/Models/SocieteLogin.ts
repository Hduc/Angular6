interface SocieteLogin {
    idEnqueteSociete: number,
    idEnquete: number,
    idSociete: number,
    dateEnqueteSociete: Date,
    nomSociete: string,
    localisation: string,
    libelleAPE2008: string,
    prenomContact: string,
    nomContact: string,
    idContact: number,
    codeAPE2008: string,
    idStatut: number,
    idStatutClient: number,
    typeEffectifAbrege:string,
    fonctionGeneriqueAbrege: string,
    idUtilisateur: number,
    idIntermediation: number,
    idListeService: number,
    idListeSousService: number,
    apercu: string,
    typeNature: string,
    icoNature: string,
    isCheck_Participants : number
}
interface ObjectResult_SocieteLogin {
    description: string;
    errorCode: string;
    result: SocieteLogin[];
}