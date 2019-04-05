interface EnqueteSociete {
    idintermediation: number,
    intermediation: string,
    idSociete: number,
    lieu: string,
    dateIntermediation: Date,
    idListeService: number,
    count: number,
    sousService: null,
    idListeSousService: number,
    siteWebIntermediation: string,
    idUtilisateur: number,
    isEventHistory : number
}
interface ObjectResult_EnqueteSociete {
    description: string;
    errorCode: string;
    result: EnqueteSociete[];
}