import { AxiosResponse } from 'axios';
import { Movie } from '../../globalTypes';
import Api from '../Instance';


export const GetMovies = async () => {
    const res: AxiosResponse<Movie[]> = await Api.get("sa/Read")
    return res.data;
}