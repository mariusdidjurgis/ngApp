import { WithId } from "../../shared/interfces/withId.interface";

export class Feature implements WithId {

    Selected: boolean;
    constructor(public Id: number, public Name: string, public Code: string, public Description: string = '') {

    }
}
