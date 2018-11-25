b = 67;
c = b;

if (a !== 0) {
    b = 106700;
    c = 123700;
}

for (; b < c; b += 17) {
    notPrime = false;

    for(var d = 2; d < b; d += 1) {
        for(var e = 2; e < b; e += 1) {
            if ((d * e) === b) {
                notPrime = true;
            }
        }
    }

    if (notPrime) {
        h += 1;
    }
}