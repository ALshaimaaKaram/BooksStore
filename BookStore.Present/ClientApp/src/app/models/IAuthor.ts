import { Byte } from "@angular/compiler/src/util";
import { IBook } from "./IBook";

export interface IAuthor {
  Id:number,
  Name:string,
  DOB:Date,
  Bio:string,
  Image:Byte,
  Authors:Array<IBook>
}
