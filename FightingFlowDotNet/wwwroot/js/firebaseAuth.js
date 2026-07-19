import {initializeApp} from "https://www.gstatic.com/firebasejs/10.13.0/firebase-app.js"
import {
    createUserWithEmailAndPassword,
    getAuth,
    GoogleAuthProvider,
    signInWithEmailAndPassword,
    signInWithPopup,
    signOut as firebaseSignOut
} from "https://www.gstatic.com/firebasejs/10.13.0/firebase-auth.js"

let auth;

export function initFirebase(config) {
    const app = initializeApp(config);
    auth = getAuth(app);
}

async function postIdTokenToServer(idToken) {
    const response = await fetch("/auth/signin",
        { method: "POST", body: idToken });
    return response.ok;
}

export async function signInWithGoogle() {
    const provider = new GoogleAuthProvider();
    const result = await signInWithPopup(auth, provider);
    const idToken =await result.user.getIdToken();
    
    return postIdTokenToServer(idToken); 
}

export async function createAccountWithEmailAndPassword(email, password) {
    const result = createUserWithEmailAndPassword(auth, email, password)
    return await postIdTokenToServer(await result.user.getIdToken());
}

export async function signinWithEmailAndPassword(email, password) {
    const result = await signInWithEmailAndPassword(auth, email, password);
    return await postIdTokenToServer(await result.user.getIdToken());
}

export async function signOut() {
    await firebaseSignOut(auth);
    const response = await fetch("/auth/signout", {method: "POST"});
    return response.ok;
}