import { WithId } from "../../shared/interfces/withId.interface";

export class Make implements WithId {
    constructor(public Id: number, public Name: string, public Date: Date, public HeadQuatersLocation: string){
            
    }
}
