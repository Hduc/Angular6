interface QuestionSociete {
    idEnqueteSociete: number,
    idQuestion: number,
    question: string,
    idTypeStockageQuestion: number
}
interface ObjectResult_QuestionSociete{
    description: string;
    errorCode: string;
    result: QuestionSociete[];
}