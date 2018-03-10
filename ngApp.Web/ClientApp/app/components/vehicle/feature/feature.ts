import { WithId } from "../../shared/interfces/withId.interface";

export class Feature implements WithId {
    constructor(public Id: number, public Name: string, public Code: string) {

    }
}
