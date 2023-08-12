import java.util.Scanner;

public class BaiTap2_4 {
public static String encrypt(String msg, int key) {
    char arr[] = new char[msg.length()];
    for (int i = 0; i < msg.length(); i++) {
        int e = (int) msg.charAt(i) + key;
        e = e > (int) 'Z' ? e - 26 : e;
        arr[i] = (char) e;
    }
    return new String(arr);
}
public static String decrypt(String msg, int key) {
    char arr[] = new char[msg.length()];
    for (int i = 0; i < msg.length(); i++) {
        int e = (int) msg.charAt(i) - key;
        e = e < (int) 'A' ? e + 26 : e;
        arr[i] = (char) e;
    }
    return new String(arr);
}
public static void main(String[] args) {
    int key = 25;
    String originalMessage = "HELLOCAESARCODE";
    String encryptedMessage = CaesarCode.encrypt(originalMessage, key);
    String decryptedMessage = CaesarCode.decrypt(encryptedMessage, key);

    System.out.println("Original Message: " + originalMessage);
    System.out.println("Encrypted Message: " + encryptedMessage);
    System.out.println("Decrypted Message: " + decryptedMessage);
}
}
public