import { GetMovies } from "../saApi/requests/movies";
import { Movie } from "../globalTypes";
import "../Style/Homepage.css";
import { useEffect, useState } from "react";
import MovieCard from "../Components/MovieCard";

export default function Homepage() {
    const [movies, setMovies] = useState<Movie[]>([]);

    async function getMoviesAsync() {
        setMovies(await GetMovies());
    }

    useEffect(() => {
        getMoviesAsync();
    }, []);

    return (
        <div className="homepage">
            <div className="cards">
                {movies.map((m, i) => {
                    console.log(m.posterURLs);
                    return <MovieCard key={i} title={m.title} posterURLs={m.posterURLs} />;
                })}
            </div>
        </div>
    );
}
