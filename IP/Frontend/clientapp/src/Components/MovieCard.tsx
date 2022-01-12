import { PosterURLs } from "../globalTypes";
import "../Style/Components/MovieCard.css";

interface IMovieCard {
    title: string;
    posterURLs: PosterURLs;
    service: string;
    link: string;
}

export default function MovieCard(prop: IMovieCard) {
    let trailerURL =
        "https://www.youtube.com/results?search_query=" +
        prop.title.replaceAll(" ", "+").replaceAll("#", "%23").replaceAll("@", "%40") +
        "+trailer";
    return (
        <div className="card">
            <img src={prop.posterURLs.original} className="card-img-top, cardImage" alt="..." />
            <div className="card-body">
                <p className="card-text">{prop.title}</p>

                <p className="card-text-info">
                    <b>Watchable on: </b>
                    <br />
                    <i>{prop.service[0].toUpperCase() + prop.service.slice(1)}</i>
                </p>
                <form className="card-text-info" action={prop.link} target="_blank">
                    <input type="submit" value="Go to Movie" />
                </form>
                <form
                    className="card-text-info"
                    onSubmit={(e) => {
                        e.preventDefault();
                        window.open(trailerURL);
                    }}
                >
                    <input type="submit" value="Go to Trailer" />
                </form>
            </div>
        </div>
    );
}
