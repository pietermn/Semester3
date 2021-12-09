// Import the functions you need from the SDKs you need
import { getAuth, signInWithEmailAndPassword } from "firebase/auth";

const auth = getAuth();

interface ILoginInfo {
    email: string;
    password: string;
}

export const SignIn = async (prop: ILoginInfo) => {
    signInWithEmailAndPassword(auth, prop.email, prop.password)
        .then((userCredential) => {
            // Signed in
            return userCredential.user;
            // ...
        })
        .catch((error) => {
            return error.code + error.message;
        });
};
