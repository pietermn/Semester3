import { Movie } from '../../globalTypes';
import Api from '../Instance';


export const GetMovies = async () => {
    let movies: Movie[] = [];
    await Api.get<Movie[]>("sa/Read")
    .then((res) => {
        movies = res.data;
    })
    
    return movies;
}