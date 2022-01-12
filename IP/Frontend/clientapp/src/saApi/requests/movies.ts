import { AxiosResponse } from 'axios';
import { Movie } from '../../globalTypes';
import Api from '../Instance';

export const GetMovies = async (services: number[], type: number, page: number) => {
    const res: AxiosResponse<Movie[]> = await (await Api.post("sa/Read?type="+type+"&page="+page, services))
    return res.data;
}

export const GetMoviesSearch = async (services: number[], type: number, page: number, search: string) => {
    const res: AxiosResponse<Movie[]> = await (await Api.post("sa/ReadSearch?type="+type+"&page="+page+"&search="+search, services))
    return res.data;
}