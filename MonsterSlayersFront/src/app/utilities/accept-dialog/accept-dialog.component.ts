import { Component, inject } from '@angular/core';
import {  MatDialog,  MAT_DIALOG_DATA,  MatDialogTitle,  MatDialogContent } from '@angular/material/dialog';

@Component({
  selector: 'app-accept-dialog',
  standalone: true,
  imports: [MatDialogTitle,  MatDialogContent],
  templateUrl: './accept-dialog.component.html',
  styleUrl: './accept-dialog.component.scss'
})
export class AcceptDialogComponent {
  data = inject(MAT_DIALOG_DATA);
}
