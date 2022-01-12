import { AxiosResponse } from 'axios';
import { Tokens } from '../../globalTypes';
import Api from '../Instance';
import saveTokenInStorage from '../Storage';

export const createUser = async (email: string, password: string) => {
    const res: AxiosResponse<Tokens> = await (await Api.post("auth/CreateUser?email="+email+"&password="+password));
    saveTokenInStorage(res.data, email);
}