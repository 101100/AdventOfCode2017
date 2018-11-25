b = 67;
c = b;

if (a !== 0) {
    b *= 100;
    b += 100000;
    c = b;
    c += 17000;
}

while (true) {
    f = false;
    d = 2;

    do {
        e = 2;
        do {
            g = d;
            g *= e;
            g -= b;

            if (g === 0) {
                f = true;
            }
            e += 1;

            g = e;
            g -= b;
            // jnz g -8
        } while (g !== 0);

        d += 1;
        g = d;
        g -= b;
        // jnz g -13
    } while (g !== 0);

    if (f) {
        h += 1;
    }

    g = b;
    g -= c;

    if (g === 0) {
        break;
    }

    b += 17;
    // jnz 1 -23
}