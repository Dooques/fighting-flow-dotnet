import {initializeApp} from "https://www.gstatic.com/firebasejs/10.13.0/firebase-app.js"
import {
    createUserWithEmailAndPassword,
    getAuth,
    GoogleAuthProvider,
    signInWithEmailAndPassword as fbSignInWithEmailAndPassword,
    signInWithPopup,
    signInWithCustomToken,
    signOut as firebaseSignOut
} from "https://www.gstatic.com/firebasejs/10.13.0/firebase-auth.js"

let auth;

export function initFirebase(config) {
    const app = initializeApp(config);
    auth = getAuth(app);
}

async function postIdTokenToServer(idToken) {
    const response = await fetch("/auth/signin", { method: "POST", body: idToken });
    return response.ok;
}

export async function signInWithGoogle() {
    const provider = new GoogleAuthProvider();
    const result = await signInWithPopup(auth, provider);
    const idToken = await result.user.getIdToken();
    return postIdTokenToServer(idToken); 
}

export async function createAccountWithEmailAndPassword(userAuth) {
    const response = await fetch("/auth/signup", {
            method: "POST", 
            headers: {"Content-Type": "application/json"},
            body: JSON.stringify(userAuth)
    });
    if (!response.ok) return false;
    
    const { customToken } = await response.json();
    const result = await signInWithCustomToken(auth, customToken);
    
    return await postIdTokenToServer(await result.user.getIdToken());
}

export async function signinWithEmailAndPassword(email, password) {
    const result = await fbSignInWithEmailAndPassword(auth, email, password);
    return await postIdTokenToServer(await result.user.getIdToken());
}

export async function signOut() {
    await firebaseSignOut(auth);
    const response = await fetch("/auth/signout", {method: "POST"});
    return response.ok;
}