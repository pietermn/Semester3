import { GetMovies, GetMoviesSearch } from "../saApi/requests/movies";
import { Movie } from "../globalTypes";
import "../Style/Homepage.css";
import { useEffect, useState } from "react";
import MovieCard from "../Components/MovieCard";
import InfiniteScroll from "react-infinite-scroll-component";

export default function Homepage() {
    const [movies, setMovies] = useState<Movie[]>([]);
    const [pages, setPages] = useState([0]);
    const [pageCount, setPageCount] = useState(0);

    let search = new URLSearchParams(window.location.search).get("search");

    function randomNumbr() {
        let nmbr = Math.round(Math.random() * (120 - 1 + 1) + 1);
        let tempPages = [...pages];
        if (tempPages.some((i) => nmbr === i)) {
            nmbr = randomNumbr();
        }
        tempPages.push(nmbr);
        setPages(tempPages);
        return nmbr;
    }

    async function getMoviesAsync() {
        setPageCount(pageCount + 1);
        if (search != null) {
            setMovies(await GetMoviesSearch([0, 1, 2, 3], 0, pageCount, search));
        } else {
            setMovies(await GetMovies([0, 1, 2, 3], 0, pageCount));
        }
    }

    async function fetchMoreData() {
        setPageCount(pageCount + 1);
        let newmovies;
        if (search != null) {
            newmovies = await GetMoviesSearch([0, 1, 2, 3], 0, pageCount, search);
        } else {
            newmovies = await GetMovies([0, 1, 2, 3], 0, pageCount);
        }
        let tempMovies = [...movies];
        newmovies.forEach((Movie) => {
            tempMovies.push(Movie);
        });
        setMovies(tempMovies);
    }

    useEffect(() => {
        getMoviesAsync();
    }, []);

    return (
        <div className="homepage">
            <InfiniteScroll
                dataLength={movies.length}
                next={fetchMoreData}
                hasMore={true}
                refreshFunction={fetchMoreData}
                loader={<h4>Loading...</h4>}
            >
                <div className="cards">
                    {movies.map((m, index) => {
                        return (
                            <MovieCard
                                key={index}
                                title={m.title}
                                posterURLs={m.posterURLs}
                                service={m.streamingInfo.service}
                                link={m.streamingInfo.link}
                            />
                        );
                    })}
                </div>
            </InfiniteScroll>
        </div>
    );
}
