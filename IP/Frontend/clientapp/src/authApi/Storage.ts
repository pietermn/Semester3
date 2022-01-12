import { Tokens } from "../globalTypes";

function saveTokenInStorage(tokens: Tokens, email: string){
    localStorage.setItem("jwtToken", tokens.jwtToken);
    localStorage.setItem("refreshToken", tokens.refreshToken);
    localStorage.setItem("email", email)
}

export default saveTokenInStorage;