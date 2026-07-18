import { initializeApp } from "https://www.gstatic.com/firebasejs/10.13.0/firebase-app.js"
import { getAuth, GoogleAuthProvider, signInWithPopup} from "https://www.gstatic.com/firebasejs/10.13.0/firebase-auth.js"

let auth;

export function initFirebase(config) {
    const app = initializeApp(config);
    auth = getAuth(app);
}

export async function signInWithGoogle() {
    const provider = new GoogleAuthProvider();
    const result = await signInWithPopup(auth, provider);
    const idToken =await result.user.getIdToken();
    
    const response = await fetch("/auth/signin-google", 
        { method: "POST", body: idToken });
    return response.ok
}