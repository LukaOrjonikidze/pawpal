import { PawbondStatus } from "../enums/pawbond-status.enum";
import { Pawpal } from "./pawpal.model";

export class Pawbond {
  id!: number;
  pawpal!: Pawpal;
  partner!: Pawpal;
  status!: PawbondStatus;
}
