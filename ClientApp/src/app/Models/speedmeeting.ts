interface Speed_Meeting {

    idEnquete: number,
    codeAPE2008: string,
    dateCreationSociete: Date,
    dejaselectionne: string,
    idEnqueteSociete: number,
    civiliteAbrege: string,
    nomContact: string,
    fonctionContact: string,
    fonctionGenerique: string,
    groupe: string,
    nomSociete: string,
    activiteSociete: string,
    departement: string,
    region: string,
    typeEffectif: string,
    typeCA: string,
    isCheck: number,
    dateEnqueteSociete: Date,
    idIntermediationContact:Date
}
interface ObjectResult_Speed_Meeting {
    description: string;
    errorCode: string;
    result: Speed_Meeting[];
}

interface Chose{
    id: number,
    ididEnquete: number,
    idEnqueteSociete: number,
    orderLevel: number
}
interface ObjectResult_Chose{
    description: string;
    errorCode: string;
    result: Chose[];
}