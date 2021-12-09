import { PosterURLs } from "../globalTypes";
import "../Style/Components/MovieCard.css";

interface IMovieCard {
    title: string;
    posterURLs: PosterURLs;
}

export default function MovieCard(prop: IMovieCard) {
    return (
        <div className="card">
            <img src={prop.posterURLs.original} className="card-img-top, cardImage" alt="..." />
            <div className="card-body">
                <p className="card-text">{prop.title}</p>
            </div>
        </div>
    );
}
