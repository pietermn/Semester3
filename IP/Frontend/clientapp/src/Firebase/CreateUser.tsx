// Import the functions you need from the SDKs you need
import { getAuth, createUserWithEmailAndPassword } from "firebase/auth";

const auth = getAuth();

interface ILoginInfo {
    email: string;
    password: string;
}

export const CreateUser = async (prop: ILoginInfo) => {
    createUserWithEmailAndPassword(auth, prop.email, prop.password)
        .then((userCredential) => {
            // Signed in
            return userCredential.user;
            // ...
        })
        .catch((error) => {
            return error.code + error.message;
        });
};
