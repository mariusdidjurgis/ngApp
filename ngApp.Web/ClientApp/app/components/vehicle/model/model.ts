import { WithId } from "../../shared/interfces/withId.interface";
import { Feature } from "../feature/feature";

export class Model implements WithId {

    public features: Array<Feature> = new Array<Feature>();

    constructor(public Id: number, private Name: string, private Date: Date, private Make: any) {
            
    }
}
