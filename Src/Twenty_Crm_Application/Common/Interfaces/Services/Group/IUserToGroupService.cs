﻿namespace Twenty_Crm_Application.Common.Interfaces.Services.Group;

public interface IUserToGroupService
{
    Task<ResponseDto<bool>> CreateManyUserToGroupAsync(IList<Guid> groupList, Guid userRef);
    Task<ResponseDto<bool>> CreateUserToGroupAsync(Guid groupId, Guid userRef);
}
