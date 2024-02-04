﻿
namespace VistaGL.Transaction {

    @Serenity.Decorators.registerClass()
    export class AccBudgetCreationDialog extends Serenity.EntityDialog<AccBudgetForDepartmentDetailRow, any> {
        protected getFormKey() { return AccBudgetCreationForm.formKey; }
        protected getIdProperty() { return AccBudgetForDepartmentDetailRow.idProperty; }
        protected getLocalTextPrefix() { return AccBudgetForDepartmentDetailRow.localTextPrefix; }
        protected getService() { return AccBudgetForDepartmentDetailService.baseUrl; }

        protected form = new AccBudgetCreationForm(this.idPrefix);

        constructor() {
            super();
        }
        protected onDialogOpen(): void {
            if (this.isEditMode()) {
                console.log(this.entity);
            }
        }
    }
}