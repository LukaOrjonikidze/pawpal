import { Pawpal } from "./pawpal.model";

export class PawBondPost {
  id!: number;
  author!: Pawpal;
  wantedPartnerAge!: number;
  wantedPartnerBreed!: string;
  wantedPartnerDescription!: string;
}
