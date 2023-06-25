import { Pawpal } from "./pawpal.model";

export class PawBondPost {
  id!: number;
  pawpal!: Pawpal;
  wantedPartner!: {
    breed: string;
    age: number;
    description: string;
  }
}
